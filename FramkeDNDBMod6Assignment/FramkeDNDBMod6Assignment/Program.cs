using FramkeDNDBMod6Assignment;
using FramkeDNDBMod6Assignment.Models;

public class Program
{

 
    private static void Main(string[] args)
    {
            Console.WriteLine("<<<<< Welcome to the Media Library >>>>>\n");
            Console.WriteLine("Choose which type of media you would like to view: ");
            Console.WriteLine("1) Display Movies");
            Console.WriteLine("2) Display Shows");
            Console.WriteLine("3) Display Videos");
            Console.WriteLine("X) Quit");

            var choice = Console.ReadLine();

        Media media = null;

        switch (choice.ToUpper())
        {
            case "1":
                media = new Movie();
                break;
            case "2":
                media = new Show();
                break;
            case "3":
                media = new Video();
                break;
            case "X":
                Console.WriteLine("Quiting program...");
                break;
            default:
                Console.WriteLine("Invalid. Try again!");
                break;
        }




        }
        }
}