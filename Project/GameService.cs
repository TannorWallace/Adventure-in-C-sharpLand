using System;
using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
  /*Game service is app*/
  public class GameService : IGameService
  {
    public IRoom CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public bool inGame { get; private set; } = true;
    public void GetUserInput()
    {
      System.Console.WriteLine($"What would you like to do.{CurrentPlayer.PlayerName}?");
      string PlayerChoice = Console.ReadLine();



    }

    public void Go(string direction)
    {
      // this is where you need to add all of your direction methods. no directions.cs
      CurrentRoom = CurrentRoom.Exits[direction];


    }

    public void Help()
    {
      System.Console.WriteLine("No its like dark souls...you figure it out. (grumpy hurrumpha!!)");

    }

    public void Inventory()
    {
      System.Console.WriteLine($"{CurrentPlayer.PlayerName}'satchel");
      foreach (var item in CurrentPlayer.Inventory)
      {
        System.Console.WriteLine(item.Name);
      }

    }

    public void Look()
    {
      System.Console.WriteLine($"{CurrentRoom.Description}");
      System.Console.WriteLine($"You enter {CurrentRoom.Name}");


    }

    public void Quit()
    {
      System.Console.WriteLine("Farewell");
      inGame = false;
    }

    public void Reset()
    {
      Setup();
      StartGame();
    }

    public void Setup()
    {
      // NOTE define a structure; list all rooms then all items, or all rooms and directions. 

      Room sketchyShack = new Room("Sketchy Shack", "You awaken in a Sketchy shack with no knowledge of how you got there. How did you get there? Where are you?");

      //leave the sketchyShack and find an axe/hammer/used hunting knife?<--that sounds far fetched but kinda dope.

      Room mistShroudedRoad = new Room(" Mist shrouded dirt road", "you leave the shack and find yourself at the end of a road covered in think mist, to thick to determine any land marks or direction");

      /*SO CONFUSED!!!! HOW WHERE AND WHEN DO I USE ITEMS!!!*/


      Room mistShroudedForest = new Room("Mist shrouded Forest", "After travelling down the misty road for a few mintues you start to see the start of what looks like a treeline...and possibly movement of a humaniod figure on the only path...");
      //   ummmm ok this is where you have a battle with a monster...


      Room theCave = new Room("The Cave", "Weery and tired from your ordeals in the forest, you see it...the source of the dreams...the source of the dark calling that has been plagueing your dreams, the source of your current plight...The cave.");

      #region possible keep exits
      //   sketchyShack.AddExit("proceed", mistShroudedRoad);
      // sketchyShack.Exits.Add("North", mistShroudedRoad);
      // mistShroudedForest.Exits.Add("North", mistShroudedForest);
      // mistShroudedForest.Exits.Add("North", theCave);
      #endregion

      Item huntingKnife = new Item("Hunting Knife", "As you leave the Sketchy Shack your boot hits something just outside the door, you look down and see a worn looking hunting knife");


      Item flashLight = new Item("Flashlight", "On the mist shrouded road you come across an abandoned car. The car seems to have what looks like dried blood on the windsheild and on the ground by the open driverside door. You approach the vehichle with eary apprehension and search the inside. You don't discover anything of real use...besides a flashlight ");
      Item molotovCocktail = new Item("Molotov Cocktail", "At the entrance of The Cave you find a convient stash of Molotov CockTails but, there is only one left inside the weathered looking box.");



      //TODO
      #region GO DIRECTIONS?
      sketchyShack.AddExit("north", mistShroudedRoad);
      mistShroudedRoad.AddExit("north", mistShroudedForest);
      mistShroudedRoad.AddExit("south", sketchyShack);
      mistShroudedForest.AddExit("north", theCave);
      mistShroudedForest.AddExit("south", mistShroudedRoad);
      theCave.AddExit("south", mistShroudedForest);
      #endregion

      #region ITEMS

      mistShroudedRoad.Items.Add(huntingKnife);
      mistShroudedForest.Items.Add(flashLight);
      mistShroudedForest.Items.Add(molotovCocktail);
      #endregion
      CurrentRoom = (Room)sketchyShack;

    }

    public void StartGame()
    //OK, I THINK ALL OF THIS SHIT HAS TO HAPPEN INSIDE OF THE WHILE LOOP FROM THE PUBLIC VOID RUN SECION OF THE PLANET EXPRESS EXAMPLE (MIDDLE FINGER)
    {
      Setup();

      Console.Clear();
      System.Console.WriteLine("");
      System.Console.WriteLine("    You set out to find respite but found only horror, the nightmares that have kept you from rest have begun to seem real....the images you had been seeing in your mind have begun to seep in to reality, after months of what has seemed like hell you are ready to face the one thing these nightmares have in common. A nameless cave in the thick forests of northern Idaho...it calls from your nightmares and draws you in your waking moments...you set out heading north, to find out who or what is behind...");
      //   System.Console.WriteLine("");
      #region ascii art
      System.Console.WriteLine(@"
 _____   _                 ___                  _        ___           _   _   _                  
/__   \ | |__     ___     /   \   __ _   _ __  | | __   / __\   __ _  | | | | (_)  _ __     __ _  
  / /\/ | '_ \   / _ \   / /\ /  / _` | | '__| | |/ /  / /     / _` | | | | | | | | '_ \   / _` | 
 / /    | | | | |  __/  / /_//  | (_| | | |    |   <  / /___  | (_| | | | | | | | | | | | | (_| | 
 \/     |_| |_|  \___| /___,'    \__,_| |_|    |_|\_\ \____/   \__,_| |_| |_| |_| |_| |_|  \__, | 
                                                                                           |___/   _   _   _ 
                                                                                                  (_) (_) (_)");
      //   System.Console.WriteLine("");
      System.Console.WriteLine(@"
                                                  ..:::::::::..
                                           ..:::aad8888888baa:::..
                                        .::::d:?88888888888?::8b::::.
                                      .:::d8888:?88888888??a888888b:::.
                                    .:::d8888888a8888888aa8888888888b:::.
                                    ::::dP::::::::88888888888::::::::Yb::::
                                   ::::dP:::::::::Y888888888P:::::::::Yb::::
                                 ::::d8:::::::::::Y8888888P:::::::::::8b::::
                                .::::88::::::::::::Y88888P::::::::::::88::::.
                                :::::Y8baaaaaaaaaa88P:T:Y88aaaaaaaaaad8P:::::
                                :::::::Y88888888888P::|::Y88888888888P:::::::
                                ::::::::::::::::888:::|:::888::::::::::::::::
`                               :::::::::::::::8888888888888b::::::::::::::'
                                :::::::::::::::88888888888888::::::::::::::
                                 :::::::::::::d88888888888888:::::::::::::
                                  ::::::::::::88::88::88:::88::::::::::::
                                   `::::::::::88::88::88:::88::::::::::'
                                     `::::::::88::88::P::::88::::::::'
                                       `::::::88::88:::::::88::::::'
                                         ``:::::::::::::::::::''
                                             ``:::::::::''");
      System.Console.WriteLine("");
      System.Console.WriteLine("                      You're alone in the dark and surrounded by monsters!");
      System.Console.WriteLine("");
      System.Console.WriteLine("Welcome to a game that was SUPPOSED to be a scary psychological thriller!!(add dramatic music here)");
      #endregion


      System.Console.WriteLine("Do you remember your name?");
      string name = Console.ReadLine();
      CurrentPlayer = new Player(name);


      while (inGame)
      {
        System.Console.WriteLine("What do you want to do?");
        string[] input = Console.ReadLine().ToLower().Split();
        string command = input[0];
        string secondary = "";
        if (input.Length > 1)
        {
          secondary = input[1];
        }
        #region switchDirectionandCommands
        switch (command)
        {
          //ok now lets try to move?
          case "go":
            Go(secondary);
            System.Console.WriteLine($"You entered{CurrentRoom.Name}.");
            break;
          case "quit":
            Quit();
            break;
          // look?
          case "look":
            Look();
            break;
          case "satchel":
            Inventory();
            break;
          case "restart":
            Reset();
            break;
          case "grab":
            TakeItem(secondary);
            break;
          case "help":
            Help();
            break;
          default:
            System.Console.WriteLine("You cannot do that");
            break;

        }



      }
      #endregion
    }
    public void TakeItem(string itemName)
    {
      Item item = CurrentRoom.Items.Find(i => i.Name.ToLower() == itemName.ToLower());
      if (item != null)
      {
        System.Console.WriteLine(item.Description);

      }

    }

    public void UseItem(string itemName)
    {

    }
  }
}