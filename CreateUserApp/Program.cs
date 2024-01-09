internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your full name in small letters:");
        String fullname = Console.ReadLine();

        //treat a middle name case

        String[] NameParts = fullname.Split(' ');

        String username;

        String Name = NameParts[0];
        String Lastname = NameParts[NameParts.Length - 1];

        if (Lastname.Length >= 3)
        {
            username = Name + Lastname.Substring(0, 3);
        }
        else
        {
            username = Name + Lastname;
        }

        Console.WriteLine("Your username is: " + username);
    }
}