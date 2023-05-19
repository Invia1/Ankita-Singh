 ﻿using Day_9.Functionality;
using Day_9.Models;
using System;


namespace Day_9.BLL
    {
    public class PlayerList : IFootballListMethod
    {
        List<Player> players = new List<Player>();

        public int CreatePlayer(Player player)
        {
            players.Add(player);
            return 1;
        }

        public List<Player> GetPlayers()
        {
            return players;
        }


        public void UpdatePlayer(int jerseyNo)
        {
            List<Player> players = GetPlayers();
            try
            {
                foreach (Player player in players)
                {
                    if (player.Jersey == jerseyNo)
                    {
                        player.Jersey = jerseyNo;
                        Console.WriteLine("Enter the updated name : ");
                        player.Name = Console.ReadLine();

                        Console.WriteLine("Enter updated country : ");
                        player.Country = Console.ReadLine();

                        Console.WriteLine("Enter update age : ");
                        player.Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter updated height : ");
                        player.Height = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void RemovePlayer(int jerseyNo)
        {
            List<Player> players = GetPlayers();

            try
            {
                foreach (Player player in players)
                {
                    if (player.Jersey == jerseyNo)
                    {
                        players.Remove(player);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SearchPlayer(int jerseyNo)
        {
            List<Player> players = GetPlayers();

            try
            {
                foreach (Player player in players)
                {
                    if (player.Jersey == jerseyNo)
                    {
                        Console.WriteLine("Player JerseyNo : " + player.Jersey);
                        Console.WriteLine("Player Name : " + player.Name);
                        Console.WriteLine("Player Country : " + player.Country);
                        Console.WriteLine("Player Age : " + player.Age);
                        Console.WriteLine("Player Height : " + player.Height);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }     
}



