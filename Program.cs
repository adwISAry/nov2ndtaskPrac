using november2nd.Models;
using november2nd.Utils;


User user = new User();

    name: 
    try
    {
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();
        user.Name = name;
    }
    catch (InvalidNameExpections ex)
    {
        Console.WriteLine(ex.Message);
        goto name;
    }
    age:
    try
    {
        Console.WriteLine("Enter Your Age");
        int age = Convert.ToInt32(Console.ReadLine());
        user.Age = age;
    }
    catch (InvalidAgeException ex )
    {
        Console.WriteLine(ex.Message);
        goto age;
    }
    phone:
    try
    {
        Console.WriteLine("Enter Your Phone Number");
        string phone = Console.ReadLine();
        user.PhoneNumber = phone;
    }
    catch (InvalidPhoneFormat ex)
    {
        Console.WriteLine(ex.Message);
        goto phone;
    }
    password:
    try
    {
        Console.WriteLine("Enter your password");
        string password = Console.ReadLine();
        user.Password = password;
    }
    catch (InvalidPasswordException ex) 
    {
        Console.WriteLine(ex.Message);
        goto password;
    }







