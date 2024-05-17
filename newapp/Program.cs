using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {   //khởi tạo 2 đối tượng
        Person ps = new Person();
        //gắn giá trị cho thuộc tính đối tượng ps1
        string str = "Nguyen Van A";
        int a = 22;
        //phương thức thực hiện thông tin
        Console.WriteLine("{0} sinh nam {1}", str, ps.GetYearOfBirth(a));
        //Student
        Student std = new Student();
        std.EnterData();
        std.StudentCode = "123456789";
        std.Display();
    }
}