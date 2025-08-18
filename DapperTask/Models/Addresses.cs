namespace DapperTask.Models
{
    public class Addresses
    {
        // id is primary key of address table auto incremented
        public int Id { get; set; }
        public int RollNo { get; set; } // Foreign key to Student table
        public string AddressType { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Pincode { get; set; } = null!;
    }
}
