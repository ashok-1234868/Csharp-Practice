using Dapper;
using DapperTask.DBConnection;
using DapperTask.Models;
using System.Data.SqlClient;

namespace DapperTask.Repositary
{
    public class StudentRepo : IStudentRepo
    {

        private readonly DbContext _dbContext;
        public StudentRepo(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddStudentAsync(Students student)
        {
            var connection = (SqlConnection)_dbContext.CreateConnection();

            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            //check if student already exists
            var checkQuery = "SELECT COUNT(*) FROM Students WHERE RollNo=@RollNo";
            var exists = await connection.ExecuteScalarAsync<int>(checkQuery, new { RollNo = student.RollNo }, transaction);
            if (exists > 0)
            {
                throw new Exception($"Student with this RollNo {student.RollNo} already exists.");
            }

            try
            {
                // 1️⃣ Insert Student
                var query = @"INSERT INTO Students (RollNo, Name, Email, MobileNo, DOB, Gender)VALUES (@RollNo, @Name, @Email, @MobileNo, @DOB, @Gender)";

                await connection.ExecuteAsync(query, student, transaction);

                // 2️⃣ Insert Addresses
                string addressQuery = @"INSERT INTO Addresses (RollNo,AddressType, Street, City, State, Pincode)VALUES (@Rollno,@AddressType, @Street, @City, @State, @Pincode);";

                foreach (var address in student.Address)
                {
                    address.RollNo = student.RollNo; // correct foreign key
                    await connection.ExecuteAsync(addressQuery, address, transaction);
                }

                // ✅ Commit transaction
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // rollback if error occurs
                transaction.Rollback();
                // log the error or throw again
                throw new Exception("Error while inserting student and addresses", ex);
            }
            finally
            {
                await connection.CloseAsync();
            }
        }








        public async Task<IEnumerable<Students>> GetAllStudentsAsync()
        {
            var connection = (SqlConnection)_dbContext.CreateConnection();
            await connection.OpenAsync();

            string sql = @"SELECT * FROM Students s
                       LEFT JOIN Addresses a ON s.RollNo = a.RollNo";

            var studentDict = new Dictionary<int, Students>();

            var result = await connection.QueryAsync<Students, Addresses, Students>(
                sql,
                (student, address) =>
                {
                    if (!studentDict.TryGetValue(student.RollNo, out var currentStudent))
                    {
                        currentStudent = student;
                        currentStudent.Address = new List<Addresses>();
                        studentDict.Add(student.RollNo, currentStudent);
                    }

                    if (address != null)
                        currentStudent.Address.Add(address);

                    return currentStudent;
                },
                splitOn: "Id"
            );

            await connection.CloseAsync();
            return studentDict.Values;
        }








        public async Task<Students> GetStudentByRollNoAsync(int rollNo)
        {
            var connection = (SqlConnection)_dbContext.CreateConnection();
            await connection.OpenAsync();

            string sql = @"SELECT * FROM Students s
                       LEFT JOIN Addresses a ON s.RollNo = a.RollNo
                       WHERE s.RollNo = @RollNo";

            var studentDict = new Dictionary<int, Students>();

            var result = await connection.QueryAsync<Students, Addresses, Students>(
                sql,
                (student, address) =>
                {
                    if (!studentDict.TryGetValue(student.RollNo, out var currentStudent))
                    {
                        currentStudent = student;
                        currentStudent.Address = new List<Addresses>();
                        studentDict.Add(student.RollNo, currentStudent);
                    }

                    if (address != null)
                        currentStudent.Address.Add(address);

                    return currentStudent;
                },
                new { RollNo = rollNo },
                splitOn: "Id"
            );

            await connection.CloseAsync();
            return studentDict.Values.FirstOrDefault();
        }







        public async Task<bool> UpdateStudentAsync(Students student)
        {
            var connection = (SqlConnection)_dbContext.CreateConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                var updateStudentQuery = @"UPDATE Students
                                       SET Name=@Name, Email=@Email, MobileNo=@MobileNo, DOB=@DOB, Gender=@Gender
                                       WHERE RollNo=@RollNo";
                await connection.ExecuteAsync(updateStudentQuery, student, transaction);

                // Optional: Delete old addresses first, then insert new ones
                var deleteAddressQuery = "DELETE FROM Addresses WHERE RollNo=@RollNo";
                await connection.ExecuteAsync(deleteAddressQuery, new { RollNo = student.RollNo }, transaction);

                var addressQuery = @"INSERT INTO Addresses (RollNo,AddressType, Street, City, State, Pincode)
                                 VALUES (@RollNo,@AddressType, @Street, @City, @State, @Pincode)";

                foreach (var address in student.Address)
                {
                    address.RollNo = student.RollNo;
                    await connection.ExecuteAsync(addressQuery, address, transaction);
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }







        public async Task<bool> DeleteStudentAsync(int rollNo)
        {


            //

            var connection = (SqlConnection)_dbContext.CreateConnection();
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();
            // check the rollNo exists or not
            var checkQuery = "SELECT COUNT(*) FROM Students WHERE RollNo=@RollNo";
            var exists = await connection.ExecuteScalarAsync<int>(checkQuery, new { RollNo = rollNo }, transaction);
            if (exists == 0)
            {
                throw new Exception("RollNo is not found please give correct Rollnumber"); // Student does not exist
            }





            try
            {
                // Delete addresses first
                string deleteAddressQuery = "DELETE FROM Addresses WHERE RollNo=@RollNo";
                await connection.ExecuteAsync(deleteAddressQuery, new { RollNo = rollNo }, transaction);

                // Delete student
                string deleteStudentQuery = "DELETE FROM Students WHERE RollNo=@RollNo";
                await connection.ExecuteAsync(deleteStudentQuery, new { RollNo = rollNo }, transaction);

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }
 
    
    }
}

