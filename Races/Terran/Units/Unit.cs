using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft1.Races.Terran.Units
{
    public class Unit : GameObject, IUnit
    {
        readonly int Damage;

        public Unit(int maxHp, Location position, int damage, EPlayerColor color): base(maxHp, position, color)
        {
           Damage = damage;
        }

        public void Attack(GameObject obj)
        {
            obj.Damaged(Damage);
        }

        public override void Move(float x, float y)
        {
            Location.ChangeLocationBy(x, y);
        }
    }
}
