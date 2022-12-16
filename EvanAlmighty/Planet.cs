using System;

namespace EvanAlmighty
{
    public class Planet
    {
        private string _name;
        private string _type;
        private bool _isHabitable;
        private uint _diameter;
        private long _distance;
        private bool _hasCivilization;
        private Civilization _civilization;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public bool IsHabitable
        {
            get { return _isHabitable; }
            set { _isHabitable = value; }
        }

        public uint Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public long Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public bool HasCivilization
        {
            get { return _hasCivilization; }
            set { _hasCivilization = value; }
        }

        public Civilization Civilization
        {
            get { return _civilization; }
            set { _civilization = value; }
        }

        public Planet(string name, string type, bool isHabitable, uint diameter, long distance, bool hasCivilization, Civilization civilization)
        {
            Name = name;
            Type = type;
            IsHabitable = isHabitable;
            Diameter = diameter;
            Distance = distance;
            HasCivilization = hasCivilization;
            Civilization = civilization;
        }
    }
}
