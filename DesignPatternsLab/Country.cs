﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    public class Country
    {

        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
        public Country(string name, string continent, List<string> colors)
        {
            this.Name = name;
            this.Continent = continent;
            this.Colors = colors;
        }
    }
}
