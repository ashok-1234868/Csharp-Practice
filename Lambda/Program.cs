namespace Lambda
{
    delegate bool Lambdas(Student obj);
    internal class Program
    {
        static void Main(string[] args)
        {
            Lambdas lamb = s => s.Age > 12 && s.Age < 20;

            Student objs = new Student();
            //objs.Age = 21;
            //objs.Name = "Ashok";
            //objs.Id = 1;

            Console.WriteLine(lamb(objs));
            Console.ReadLine();
        }
    }
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }   
        public int Id { get; set; }
    }
}
