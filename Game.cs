using StarCraft1.Races.Terran;
using StarCraft1.Races.Terran.Builds;
using StarCraft1.Races.Terran.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft1
{
    public static class Game
    {
        public static List<GameObject> list = new List<GameObject>();

        public static List<T> GetListOfObjects<T>()
        {
            List<T> objects = new();

            foreach (var elem in list)
            {
                if (elem is T cc)
                    objects.Add(cc);
            }

            return objects;
        }
    }
}
