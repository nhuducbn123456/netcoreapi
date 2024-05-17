namespace NewApp.Models
{
    public class Student : Person
    {
        public Student(string studentCode) 
        {
            this.StudentCode = studentCode;
   
        }
        public Student(string studentCode) 
        {
            this.StudentCode = studentCode;
   
        }
                        public string StudentCode {get;set;}
    }
    public void EnterData()
    {
        base.EnterData();
        System.Console.WriteLine("Student Code = ");
        StudentCode = Console.ReadLine();
    }
    
}