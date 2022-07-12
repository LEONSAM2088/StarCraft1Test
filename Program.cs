// See https://aka.ms/new-console-template for more information
using StarCraft1;
using StarCraft1.Races;
using StarCraft1.Races.Terran;
using StarCraft1.Races.Terran.Builds;
using StarCraft1.Races.Terran.Units;

Console.WriteLine("Hello, World!");


Worker worker = new(new Location(0,0), EPlayerColor.RED);
Game.list.Add(worker);
worker.Build(BuildingType.CommandCenter);


// Console.WriteLine(Game.GetListOfObjects<ComandCenter>());


