// See https://aka.ms/new-console-template for more information


using SC1GameObj;



Game.CreateGameObject<Worker>(new Location(0, 0), EPlayerColor.RED);

Game.CreateGameObject<Worker>(new Location(0, 1), EPlayerColor.RED);

Game.CreateGameObject<Building>(new Location(0, 1), EPlayerColor.RED);



//Console.WriteLine(Game.GetAllUnits(EPlayerColor.RED).ToArray()[0].Hp);
//Console.WriteLine(Game.GetAllUnits(EPlayerColor.RED).ToArray()[1].Hp);
Console.WriteLine(Game.GetListOfObjects<Unit>().Where(x => x.MyId == 0).Count());

Game.DeleteGameObjectById<Worker>(0);



//var worker = Game.GetListOfObjects<Worker>().Where(x => x.Color == EPlayerColor.RED).First();


