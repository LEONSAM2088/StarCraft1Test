
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC1GameObj
{
    public static class Game 
    {
        private  static readonly List<GameObject> list = new();

        public static IEnumerable<GameObject> GetListOfObjects<T>()
        {           
            foreach (var elem in list)
            {
                if (elem is T)
                    yield return elem;
            }
        }

        
        
        public static void CreateGameObject<T>(Location location, EPlayerColor color) where T :GameObject, new()
        {
            var cc = new T();
            cc.SetLocation(location);
            cc.SetColor(color);
            list.Add(cc);

            Console.WriteLine($"Создан игровой объект {typeof(T).Name}");
            Console.WriteLine($"ID {cc.MyId}");
            Console.WriteLine($"HP {cc.Hp}");
            Console.WriteLine($"Location X={cc.Location!.X} Y={cc.Location.Y}");
           
        }

        public static void DeleteGameObjectById<T>(int id) where T :GameObject
        {

            list.Remove(GetListOfObjects<T>().Where(x => x.MyId == id).First());
            Console.WriteLine($"Удален игровой объект {typeof(T).Name}");
            Console.WriteLine($"ID {id}");
            
        }
    }
}
