using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramkeDNDBMod6Assignment.Models
{
    public class Show : Media
    {
        public int Season { get; set; }
        public int Episode {  get; set; }
        public string Writers { get; set; }

        public override string Display()
        {
            string showInfo = $"Show ID: {Id}\nTitle: {Title}\nSeason: {Season}\nEpisode: {Episode}\nWriters: {Write}";

            return showInfo;
        }
    }
}
