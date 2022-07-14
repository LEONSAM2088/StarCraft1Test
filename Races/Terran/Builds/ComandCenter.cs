using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public class ComandCenter : Building
    {
        const int maxHp = 5000;
       
        public Location spawnCSVLocation;
        public bool IsFlying { get; private set; }
        public int[] OrderList = new int[6];
        public int[] StorageCSV = new int[5];
       

        public ComandCenter(): base()
        {

            spawnCSVLocation = Location;

            SetHp(maxHp);
        }
        

        public void Up() {
            IsFlying = true;
        }
        public void Down() {
            IsFlying = false;
        }

        public override void Move(float x, float y)
        {
            if (IsFlying)
                Location!.ChangeLocationBy(x, y);
        }



    }
}
