using System;
using System.Collections.Generic;
using CastleGrimtol.Project.Interfaces;
using CastleGrimtol.Project.Models;

namespace CastleGrimtol.Project
{
  public class GameService : IGameService
  {
    public IRoom CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public bool playing { get; private set; }
    public void GetUserInput()
    {
      System.Console.WriteLine($"What would you like to do.{CurrentPlayer.PlayerName}?");
      string PlayerChoice = Console.ReadLine();
      switch (PlayerChoice.ToLower())
      {
        case "leave shack":
          Go("Leave Shack");
          break;
        //umm...i think this  is correct? will this allow me to type in look around?
        case "look around":
          Look();
          break;


      }

    }

    public void Go(string direction)
    {
      // this is where you need to add all of your direction methods. no directions.cs


    }

    public void Help()
    {

    }

    public void Inventory()
    {

    }

    public void Look()
    {
      System.Console.WriteLine($"You enter {CurrentRoom.Name}");
      System.Console.WriteLine($"{CurrentRoom.Description}");

    }

    public void Quit()
    {

    }

    public void Reset()
    {

    }

    public void Setup()
    {
      Room sketchyShack = new Room("Sketchy Shack", "You awaken in a Sketchy shack with no knowledge of how you got there. How did you get there? Where are you?");
      //leave the sketchyShack and find an axe/hammer/used hunting knife?<--that sounds far fetched but kinda dope.
      Room mistShroudedRoad = new Room(" Mist shrouded dirt road", "you leave the shack and find yourself at the end of a road covered in think mist, to thick to determine any land marks or direction");

      Room mistShroudedForest = new Room("Mist shrouded Forest", "After travelling down the misty road for a few mintues you start to see the start of what looks like a treeline...and possibly movement of a humaniod figure on the only path...");
      //   ummmm ok this is where you have a battle with a monster...
      // I also dont know if to add more forest or not...
      Room theCave = new Room("The Cave", "Weery and tired from your ordeals in the forest, you see it...the source of the dreams...the source of the dark calling that has been plagueing your dreams, the source of your current plight...The cave.");
      //maybe prompt for choices here? rest? or proceed into the cave? run back to the forest? <--idk thats kinda dumb


    }

    public void StartGame()
    {
      Console.Clear();
      System.Console.WriteLine("");
      System.Console.WriteLine("    You set out to find respite but found only horror, the nightmares that have kept you from rest have begun to seem real....the images you had been seeing in your mind have begun to seep in to reality, after months of what has seemed like hell you are ready to face the one thing these nightmares have in common. A nameless cave in the thick forests of northern Idaho...it calls from your nightmares and draws you in your waking moments...you set out heading north, to find out who or what is behind...");
      //   System.Console.WriteLine("");

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

    }

    public void TakeItem(string itemName)
    {

    }

    public void UseItem(string itemName)
    {

    }
  }
}