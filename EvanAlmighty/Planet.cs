﻿using System;

namespace EvanAlmighty
{
    public class Planet : PlanetaryBody
    {
        private string _type;
        private bool _isHabitable;
        private bool _hasCivilization;
        private Civilization _civilization;

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

        public Planet(string name, string type, bool isHabitable, int diameter, long distance, bool hasCivilization, Civilization civilization)
        {
            Name = name;
            Type = type;
            IsHabitable = isHabitable;
            Diameter = diameter;
            Distance = distance;
            HasCivilization = hasCivilization;
            Civilization = civilization;
        }

        public Planet() { }
    }
}
