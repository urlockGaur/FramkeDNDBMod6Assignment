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

        public override string Display()
        {
            string videoInfo = $"Video ID: {Id}\nTitle: {Title}\nFormat: {Format}\nLength: {Length}\nRegion: {Regions}";

            return videoInfo;
        }
    }
}
