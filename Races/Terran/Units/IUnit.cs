using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public interface IUnit
    {
        
        public void Move(float x, float y);

        

        public void Attack(GameObject obj);
    }
}
