using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public class Worker : Unit, IWorker
    {

        public const int MaxHp = 250;
        const int WorkerDamage = 5;
      
        public Worker() : base()
        {
            SetDamage(WorkerDamage);
            SetHp(MaxHp);
        }



        public void Build(BuildingType buildingType)
        {
            if (buildingType == BuildingType.CommandCenter) {
                Game.CreateGameObject<ComandCenter>(Location!, Color);
            }
                
                
        }
    }
}
