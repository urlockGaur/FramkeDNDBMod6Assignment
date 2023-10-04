﻿using System;
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

        public override void Display()
        {
       
            Console.WriteLine($"Show ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Season: {Season}");
            Console.WriteLine($"Episode: {Episode}");
            Console.WriteLine($"Writers: {Writers}");
        
        }
    }
}
