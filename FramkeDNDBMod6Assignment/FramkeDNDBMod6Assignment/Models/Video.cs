using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramkeDNDBMod6Assignment.Models
{
    public class Video : Media
    {

        public string Format { get; set; }

        public int Length { get; set; }

        public string Regions { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Video ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Format: {Format}");
            Console.WriteLine($"Length: {Length} minutes");
            Console.WriteLine($"Regions: {Regions}");
        }
    }
}
