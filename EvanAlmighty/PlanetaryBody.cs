using System;
namespace EvanAlmighty
{
    public class PlanetaryBody
    {
        private string _name;
        private int _diameter;
        private long _distance;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public long Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }
    }
}
