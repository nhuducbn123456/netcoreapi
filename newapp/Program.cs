using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        //khởi tạo 2 đối tượng
        Person ps1 = new Person();
        Person ps2 = new Person();
        //gắn giá trị cho thuộc tính đối tượng ps1
        ps1.FullName = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        //phương thức thực hiện thông tin
        ps1.Display();
        ps2.Display();
    }
}