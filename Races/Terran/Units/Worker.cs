using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    
    public class Worker : Unit, IWorker
    {

        
      
        public Worker() : base()
        {
            SetDamage(Consts.WorkerDamage);
            SetHp(Consts.WorkerMaxHp);
        }



        public void Build(BuildingType buildingType)
        {
            if (buildingType == BuildingType.CommandCenter) {
                Game.CreateGameObject<ComandCenter>(Location, Color);
            }
                
                
        }
    }
}
