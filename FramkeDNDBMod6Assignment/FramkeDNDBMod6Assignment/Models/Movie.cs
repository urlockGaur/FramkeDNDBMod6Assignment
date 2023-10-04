using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramkeDNDBMod6Assignment.Models
{
    public class Movie : Media
    {
        public string Genres { get; set; }

        public override void Display()
        {

            Console.WriteLine($"Movie ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genres: {Genres}");

        }
    }
}
