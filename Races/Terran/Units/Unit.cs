using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public class Unit : GameObject, IUnit
    {
        public int Damage { get; private set; }

        
        public Unit() : base()
        {
            
        }
        public void Attack(GameObject obj)
        {
            
                obj.Damaged(Damage);
        }
        public void SetDamage(int dmg)
        {
            Damage = dmg;
        }

        public override void Move(float x, float y)
        {
            Location!.ChangeLocationBy(x, y);
        }
    }
}
