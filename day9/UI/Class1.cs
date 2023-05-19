using Day_9.BLL;
using Day_9.Functionality;
using Day_9.Models;
using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Day_9.UI
{
    class FootballPlayersApp
    {
        static void Main()
        {
            int jerseyNo;
            string confirm;
            Player player;
            IFootballListMethod FBT = new PlayerList();
            do
            {
                Console.WriteLine("Press 1 To Add New Players In List");
                Console.WriteLine("Press 2 To Show Players In List");
                Console.WriteLine("Press 3 To Update Players In List");
                Console.WriteLine("Press 4 To Search Players In List");
                Console.WriteLine("Press 5 To Remove Players In List");
                Console.WriteLine("Press 6 To Exit The Program");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        player = new Player();
                        Console.WriteLine("Enter the Jersey no : ");
                        player.Jersey = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the Player Name : ");
                        player.Name = Console.ReadLine();

                        Console.WriteLine("Enter the country : ");
                        player.Country = Console.ReadLine();

                        Console.WriteLine("Enter the Age of the Palyer : ");
                        player.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the height of the Player : ");
                        player.Height = Convert.ToDouble(Console.ReadLine());

                        FBT.CreatePlayer(player);
                        break;
                    case 2:
                        Console.WriteLine("-------Player List------");
                        List<Player> playerList = FBT.GetPlayers();
                        Console.WriteLine("");
                        foreach (var players in playerList)
                        {
                            Console.WriteLine("Player JerseyNo : " + players.Jersey);
                            Console.WriteLine("Player Name : " + players.Name);
                            Console.WriteLine("Player Country : " + players.Country);
                            Console.WriteLine("Player Age : " + players.Age);
                            Console.WriteLine("Player Height : " + players.Height);
                            Console.WriteLine("");
                            Console.WriteLine("");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Which player do you want to update, please enter jersey no. of that player?");
                        jerseyNo = Convert.ToInt32(Console.ReadLine());
                        FBT.UpdatePlayer(jerseyNo);
                        break;
                    case 4:
                        Console.WriteLine("Which player do you want to search, please enter jersey no. of that player?");
                        jerseyNo = Convert.ToInt32(Console.ReadLine());
                        FBT.SearchPlayer(jerseyNo);
                        break;
                    case 5:
                        Console.WriteLine("Which player do you want to remove, please enter jersey no. of that player?");
                        jerseyNo = Convert.ToInt32(Console.ReadLine());
                        FBT.RemovePlayer(jerseyNo);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue the program ? If yes press 'Y' else 'N' ");
                confirm = Console.ReadLine();
            } while (confirm == "Y");
        }
    }
}