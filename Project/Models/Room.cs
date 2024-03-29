using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using System;
using System.Threading;

namespace CastleGrimtol.Project.Models
{
  public class Room : IRoom
  {


    public string Name { get; set; }
    public string Description { get; set; }
    public string AltDescription { get; set; } //NOTE this could be the description for after items have been taking
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    public void AddExit(string direction, IRoom room)
    {
      Exits.Add(direction, room);
    }


    public void AddItem(Item item)
    {
      Items.Add(item);
    }

    public IRoom Go(string direction)
    {
      if (Exits.ContainsKey(direction))
      {
        System.Console.WriteLine("You're alone in the dark and surrounded by monsters...");
        Thread.Sleep(3000);
        Console.Clear();
        return Exits[direction];
      }
      // System.Console.WriteLine("Something tells you you should try another way!");
      //ok that took forfreaking ever! 
      return this;
    }

    public IRoom GetRoom(string direction)
    {
      throw new NotImplementedException();
    }

    /* -------------------------- Below is your constructor---------------------------------------------------------*/
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Exits = new Dictionary<string, IRoom>();
      //super confused face
      // NOTE exits should be based on directions you want your user to be able to go  
    }
  }
}