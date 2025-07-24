using CSharp.List;
using CSharp.Delegates;
using CSharp.Inheritance;
using CSharp.Polymorphism;

namespace CSharp.Inheritance
{

    public class Program
    {
        public static void Main(String[] args)
        {
            Overloading obj = new Overloading();
            obj.name = "Anbu";
            obj.address = "Salem-636114";
            obj.a = 10;
            obj.b = 20;
            obj.age = 21;
            obj.Sample(obj.name, obj.age);
            obj.Sample(obj.a, obj.b);
            obj.Sample(obj.name, obj.age);
            obj.Sample();
        }
    }
}
