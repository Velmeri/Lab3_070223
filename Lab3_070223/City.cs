using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3_070223
{
    class City
    {
        private string _name;
        private string _country;
        private int _inhabitants;
        private string[] _areas;
        public string Name { get { return _name; } set { _name = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public int Inhabitants { get { return _inhabitants; } set { Inhabitants = value; } }
        public string[] Areas { get { return _areas; } set { _areas = value; } }
        public City() 
        {
            Name = null;
            Country = null;
            Inhabitants = 0;
            Areas = null;
        }
        public City(string name, string country, int inhabitants, string[] areas)
        {
            Name = name;
            Country = country;
            Inhabitants = inhabitants;
            Areas = areas;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
