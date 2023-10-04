using FramkeDNDBMod6Assignment;
using FramkeDNDBMod6Assignment.Models;

public class Program
{
    //you will notice that a movie, show and video of ID 0 populates. can't seem to figure out why at this point
 
    private static void Main(string[] args)
    {

        bool quit = false;

        while (!quit)
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
                    ((Movie)media).Display();
                    ReadParsedCSV("movies.csv", media);
                    break;
                case "2":
                    media = new Show();
                    ((Show)media).Display();
                    ReadParsedCSV("shows.csv", media);
                    break;
                case "3":
                    media = new Video();
                    ((Video)media).Display();
                    ReadParsedCSV("videos.csv", media);
                    break;
                case "X":
                    Console.WriteLine("Quiting program...");
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid. Try again!");
                    break;
            }
            if (!quit)
            {
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }

    static void ReadParsedCSV(string filePath, Media media)
    {
        try
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1)) //skips header
            {
                var data = line.Split(','); //comma delimiter


                //movie
               if (data.Length >= 3) 
                {
                    if (media is Movie movie)
                    {
                        movie.Id = int.Parse(data[0]);
                        movie.Title = data[1];  
                        movie.Genres = data[2];
                        movie.Display();
                    }
                    else if (media is Show show && data.Length >= 5)
                    {
                        show.Id = int.Parse(data[0]);
                        show.Title = data[1];
                        show.Season = int.Parse(data[2]);
                        show.Episode = int.Parse(data[3]);
                        show.Writers = data[4];
                        show.Display();
                    }
                    else if (media is Video video && data.Length >= 5)  
                    {
                        video.Id = int.Parse(data[0]);
                        video.Title = data[1];
                        video.Format = data[2];
                        video.Length = int.Parse(data[3]);
                        video.Regions = data[4];
                        video.Display();
                    }
                }
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading CSV file: " + e.Message);
        }
    }
}
