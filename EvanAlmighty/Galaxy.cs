using System;

namespace EvanAlmighty
{
    public class Galaxy
    {
        private Star[] _stars;

        public Star[] Stars
        {
            get { return _stars; }
            set { _stars = value; }
        }

        public Galaxy(Star[] stars)
        {
            Stars = stars;
        }
    }
}
