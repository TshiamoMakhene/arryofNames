using System.Runtime.InteropServices;

namespace arryofNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userName = new string[5];
            
            for (int i =0; i < userName.Length; i++)
            {
                Console.WriteLine($"Please enter five names {i+1} :");
               userName[i] = Console.ReadLine();
                
            }
            Console.WriteLine( "The names you have entered are :");
            foreach (string user in userName)
            {
                Console.WriteLine( user);
            }
        }
    }
}
