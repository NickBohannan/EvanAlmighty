using System;
using System.Text;

namespace EvanAlmighty
{
    public static class GalaxyGenerator
    {

        public static Galaxy GenerateGalaxy(int starNumber)
        {
            Star[] stars = new Star[starNumber];

            for (int i = 0; i < starNumber; i++)
            {
                stars[i] = GenerateStar();
            }

            Galaxy galaxy = new Galaxy(stars);

            return galaxy;
        }

        private static Star GenerateStar()
        {
            Random rnd = new Random();

            string name = GenerateName();
            long diameter = rnd.Next(GalacticConstants.StellarDiameterMin, GalacticConstants.StellarDiameterMax) * 1000;
            int x = rnd.Next(0, GalacticConstants.Xmax);
            int y = rnd.Next(0, GalacticConstants.Ymax);
            Planet[] planets = GeneratePlanets(name);

            return new Star(name, diameter, x, y, planets);
        }

        private static Planet[] GeneratePlanets(string starName)
        {
            Random rnd = new Random();

            int planetNumber = rnd.Next(1, 15);
            Planet[] planets = new Planet[planetNumber];

            for (int i = 0; i < planetNumber; i++)
            {
                planets[i] = new Planet();

                planets[i].Name = $"{starName} {i+1}";
                planets[i].Distance = rnd.Next(GalacticConstants.PlanetDistanceMin, GalacticConstants.PlanetDistanceMax);

                if (planets[i].Distance > GalacticConstants.RockDistanceMax)
                {
                    planets[i].Type = "gaseous";
                    planets[i].Diameter = rnd.Next(GalacticConstants.GasDiameterMin, GalacticConstants.GasDiameterMax);
                }
                else
                {
                    planets[i].Type = "rocky";
                    planets[i].Diameter = rnd.Next(GalacticConstants.RockDiameterMin, GalacticConstants.RockDiameterMax);
                }

                if (planets[i].Distance >= GalacticConstants.HabitableDistanceMin && planets[i].Distance <= GalacticConstants.HabitableDistanceMax)
                {
                    planets[i].IsHabitable = true;
                }
                else
                {
                    planets[i].IsHabitable = false;
                }

                if (rnd.NextDouble() * GalacticConstants.GlobalCivChance < 1 && planets[i].IsHabitable == true)
                {
                    planets[i].HasCivilization = true;
                    planets[i].Civilization = GenerateCivilization();
                }
                else
                {
                    planets[i].HasCivilization = false;
                    planets[i].Civilization = null;
                }
            }

            return planets;
        }

        private static Civilization GenerateCivilization()
        {
            Random rnd = new Random();
            double techCheck = rnd.NextDouble() * 100;
            string techLevel;

            if (techCheck >= 66)
            {
                techLevel = "FTL";
            }
            else if (techCheck <= 33)
            {
                techLevel = "primitive";
            }
            else
            {
                techLevel = "pre-FTL";
            }

            string name = GenerateName();
            string type = CivDetails.BodyType[rnd.Next(0, CivDetails.BodyType.Length)];
            string bodyCovering;
            string skinColor = CivDetails.SkinColor[rnd.Next(0, CivDetails.SkinColor.Length)];

            switch(type)
            {
                case "aquatic":
                    if (rnd.Next(0, 2) == 0)
                    {
                        bodyCovering = "rubbery skin";
                    }
                    else
                    {
                        bodyCovering = "scales";
                    }
                    break;
                case "terrestrial":
                    if (rnd.Next(0, 2) == 0)
                    {
                        bodyCovering = "skin";
                    }
                    else
                    {
                        bodyCovering = "fur";
                    }
                    break;
                case "subterranean":
                    bodyCovering = "skin";
                    break;
                case "insectoid":
                    bodyCovering = "carapace";
                    break;
                case "avian":
                    bodyCovering = "feathers";
                    break;
                case "liquid":
                    bodyCovering = "liquid";
                    break;
                case "gaseous":
                    bodyCovering = "gas";
                    break;
                case "fungal-like":
                    bodyCovering = "fruit body";
                    break;
                default:
                    bodyCovering = "N/A";
                    break;
            }

            string body = $"{skinColor} {bodyCovering}";

            return new Civilization(name, techLevel, body, type);
        }

        private static string GenerateName()
        {
            Random rnd = new Random();

            int nameRounds = (rnd.Next(1, 3) + 2);
            string[] nameArray = new string[nameRounds * 2];

            for (int i = 0; i < nameRounds * 2; i += 2)
            {
                nameArray[i] = CivNames.Consonants[rnd.Next(0, CivNames.Consonants.Length)];
                nameArray[i + 1] = CivNames.Vowels[rnd.Next(0, CivNames.Vowels.Length)];
            }

            string finalLowercaseName = string.Join("", nameArray);

            string finalName = char.ToUpper(finalLowercaseName[0]) + finalLowercaseName.Substring(1);

            return finalName;
        }
    }
}
