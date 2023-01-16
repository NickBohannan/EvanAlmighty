using System;

namespace EvanAlmighty
{
    public class Moon : PlanetaryBody
    {
        private string _parentPlanet;

        public string ParentPlanet
        {
            get { return _parentPlanet; }
            set { _parentPlanet = value; }
        }

        public Moon(string name, int diameter, long distance, string parentPlanet)
        {
            Name = name;
            Diameter = diameter;
            Distance = distance;
            ParentPlanet = parentPlanet;
        }
    }
}
