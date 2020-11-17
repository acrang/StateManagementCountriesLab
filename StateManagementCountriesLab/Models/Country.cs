using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementCountriesLab.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public List<string> Colors { get; set; }

        public Country (string Name, string Language, string Greeting, string Description, params string[] Colors)
        {
            this.Name = Name;
            this.Language = Language;
            this.Greeting = Greeting;
            this.Description = Description;
            this.Colors = Colors.ToList();
        }

        public Country()
        {

        }
    }
}
