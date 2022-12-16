using System;

namespace EvanAlmighty
{
    public class Civilization
    {
        private string _name;
        private string _techLevel;
        private string _body;
        private string _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string TechLevel
        {
            get { return _techLevel; }
            set { _techLevel = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Civilization(string name, string techLevel, string body, string type)
        {
            Name = name;
            TechLevel = techLevel;
            Body = body;
            Type = type;
        }
    }
}
