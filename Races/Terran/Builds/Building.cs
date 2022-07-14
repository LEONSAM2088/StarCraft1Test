using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public enum BuildingStatus
    {
        STARTED,
        ENDED
    }

    public enum BuildingType
    {
        CommandCenter
    }

    public class Building : GameObject, IBuilding
    {
        
        

        
        public Building() : base()
        {
           
        }

        public void SetBuildingStatus(BuildingStatus buildingStatus)
        {
            throw new NotImplementedException();
        }

        public void CancelBuilding()
        {
            throw new NotImplementedException();
        }

        public void DestructSelf()
        {
            throw new NotImplementedException();
        }

        public int GetHP()
        {
            throw new NotImplementedException();
        }

        public void StartBuilding()
        {
            throw new NotImplementedException();
        }

        public void StopBuilding()
        {
            throw new NotImplementedException();
        }

        
    }
}
