using System;

public delegate void delWelcomeMessage();

class Program
{
	static void Main()
	{
		delWelcomeMessage _delWelcomeMessage=new delWelcomeMessage(WelcomeMessage);
		_delWelcomeMessage.AddStudent();
		
	}		
	public static void WelcomeMessage()
	{
		Console.WriteLine("Delegates..");
	}
}
public class Student
{
	public string Name{get;set;}
	
	public static  void AddStudent(delWelcomeMessage callback)
	{
		Console.WriteLine("CallBack");
		callback();
		
	}
		