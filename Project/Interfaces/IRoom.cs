using System.Collections.Generic;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project.Interfaces
{
  public interface IRoom
  {
    string Name { get; set; }
    string Description { get; set; }

    /*need to work with this some how to get this to accept and return rooms? >:( when called */
    List<Item> Items { get; set; }
    Dictionary<string, IRoom> Exits { get; set; }
    IRoom Go(string direction);
    IRoom GetRoom(string direction);
    void Items();
  }
}
