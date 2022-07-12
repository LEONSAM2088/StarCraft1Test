using StarCraft1.Races.Terran.Builds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft1.Races.Terran.Units
{
    public interface IWorker
    {
        public void Build(BuildingType buildingType);
    }
}
