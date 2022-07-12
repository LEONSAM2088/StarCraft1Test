using StarCraft1.Races.Terran.Builds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft1.Races.Terran.Units
{
    public class Worker : Unit, IWorker
    {
        const int MaxHp = 250;
        const int WorkerDamage = 5;
        public Worker(Location position, EPlayerColor color): base(MaxHp, position, WorkerDamage, color) {
           
        }

        

        public void Build(BuildingType buildingType)
        {
            if(buildingType == BuildingType.CommandCenter)
            Game.list.Add(new ComandCenter(Color, Location));
        }
    }
}
