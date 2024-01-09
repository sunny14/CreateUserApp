internal class Program
{
    /*
     * The program gets a full name 
     * It creates a username: name + 3 first letters of the last name
     * If the last name contains less than 3 letters, then username will be: name + last name
     * If there is no last name, then username will consist from the name only
     * If there is a middle name, it will be ignored
     * 
     * Examples:
     * 
     * full name: john wick  -> username: johnwic
     * full name: jack ma -> username: jackma
     * full name: santana -> username: santana
     * full name: jerry lee lewis -> username: jerrylew
     */
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your full name in small letters:");
        String fullname = Console.ReadLine();

        String[] NameParts = fullname.Split(' ');

        String Name = NameParts[0];
        String Lastname = "";
        if (NameParts.Length > 1)
        {
            Lastname = NameParts[NameParts.Length - 1];
        }


        String username;
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