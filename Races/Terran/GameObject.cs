using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft1.Races.Terran
{
    public abstract class GameObject: IEnumerable<GameObject>
    {
        public const float visionDistance = 800;

        public readonly EPlayerColor Color;

        public Location Location { get; private set; }

        public int Hp { get; private set; }

        public GameObject(int maxHp, Location location, EPlayerColor color)
        {
            Hp = maxHp;
            Location = location;
            Color = color;
        }

        public void Damaged(int damage)
        {
            if (damage >= Hp)
                Hp = 0;
            else
                Hp -= damage;
        }

        public virtual void Move(float x, float y)
        {
                
        }

        public IEnumerator<GameObject> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
