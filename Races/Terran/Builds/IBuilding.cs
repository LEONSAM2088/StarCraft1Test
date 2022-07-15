using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public interface IBuilding
    {
        public void StartBuilding();
        public void StopBuilding();
        public void DestructSelf(); 
        public void SetBuildingStatus(BuildingStatus buildingStatus);
        public void CancelBuilding();

        public int GetHP();

        public void Damaged(ushort damage);
    }
}
