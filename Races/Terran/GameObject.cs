using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public enum EPlayerColor
    {
        RED,
        GREEN,
        BLUE
    }

    public abstract class GameObject
    {
        
        public static int Id { get;private set; }
        public int MyId { get; private set; }

        

        //public const float visionDistance = 800;

        public EPlayerColor Color { get; private set; }

        public Location Location { get; private set; } = null!;

        public int Hp { get; private set; }

        public GameObject() => MyId = Id++;

        
        public void Damaged(int damage)
        {
          if (damage >= Hp)
                Hp = 0;
            else
                Hp -= damage;
        }

        public virtual void Move(float x, float y)
        {
            if (Location != null)
                Location.ChangeLocationBy(x, y);
            else
                throw new Exception("Location is null!");
        }

        public void SetLocation(Location location) => Location = location;
       
        public void SetHp(int hp) => Hp = hp;
        
        public void SetColor(EPlayerColor color) => Color = color;
        

        
    }
}
