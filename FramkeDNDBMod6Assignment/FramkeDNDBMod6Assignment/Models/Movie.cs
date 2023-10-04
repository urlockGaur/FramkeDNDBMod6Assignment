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

        public override string Display()
        {
            string movieInfo = $"Movie ID: {Id}\nTitle: {Title}\nGenre: {Genres}";

            return movieInfo;
        }
    }
}
