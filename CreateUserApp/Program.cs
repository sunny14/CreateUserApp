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
        //get full name
        Console.WriteLine("Enter full name:");
        String Fullname = Console.ReadLine();

        String[] NameParts = Fullname.Split(' ');

        //create username
        String Name = NameParts[0];
        String Lastname = NameParts[NameParts.Length-1];

        String addition;
        if (Lastname.Length >=3 )
        {
            addition = Lastname.Substring(0, 3);
        } else
        {
            addition = Lastname;
        }

        String Username = Name + addition;


        Console.WriteLine("Your username is: "+Username);
    }
}