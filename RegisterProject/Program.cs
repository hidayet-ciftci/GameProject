using RegisterProject.campaign1;
using RegisterProject.game;
using RegisterProject.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new NewServiceManager());
            // PlayerManager playerManager2 = new PlayerManager(new PlayerValidationManager());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            Players player1 = new Players
            {
                Id = 1,
                Ad = "Ahmet",
                Soyad = "Cemil",
                TcNo = "422153450",
                BirthDate = "1902-05-15"
            };
            Players player2 = new Players
            {
                Id = 2,
                Ad = "Mehmet",
                Soyad = "Barış",
                TcNo = "12346548",
                BirthDate = "1992-08-07"
            };
            Players player3 = new Players
            {
                Id = 3,
                Ad = "Cemil",
                Soyad = "Karış",
                TcNo = "4652317",
                BirthDate ="2002-08-07"
            };
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);
            foreach (Players player in playerManager.Players)
            {
                Console.WriteLine(player.Ad + " " + player.Soyad);
            }
            Console.WriteLine("----------------- Silme Kısmı ------------------");
            playerManager.Delete(player2);
            foreach (Players player in playerManager.Players)
            {
                Console.WriteLine(player.Ad + " " + player.Soyad);
            }
            Console.WriteLine("-------------- Update Kısmı ------------------");
            foreach (Players item in playerManager.Players)
            {
                if (item.Id==1)
                {
                    Console.WriteLine(item.Id + " " +item.Ad + " " + item.Soyad + " " + item.TcNo + " " + item.BirthDate);
                }
            }
            Console.WriteLine("-------------- Update Kısmı --------------------");
            Players player4 = new Players
            {
                Id = 1,
                Ad = "Ahmet",
                Soyad = "Cemil",
                TcNo = "111111111",
                BirthDate = "2002-05-05"
            };
            playerManager.Update(player4);
            foreach (Players item in playerManager.Players)
            {
                if (item.Id == 1)
                {
                    Console.WriteLine(item.Id + " " + item.Ad + " " + item.Soyad + " " + item.TcNo + " " + item.BirthDate);
                }
            }
            Console.WriteLine("------------------ Validasyon Kısmı ---------------------");
            Players player5 = new Players
            {
                Id = 3,
                Ad = "Cemil",
                Soyad = "bakiş",
                TcNo = "111",
                BirthDate = "2002-08-07"
            };
            Console.WriteLine("ID 3 olan oyuncunun : ");
            
            Console.WriteLine("------------ Oyun kısmı --------------");
            Game game1 = new Game 
            {
                Id=1,
                Name="Lol",
                Number=50,
                Price=75
            };
            Game game2 = new Game
            {
                Id = 2,
                Name = "CS",
                Number = 25,
                Price = 45
            };
            gameManager.SellGame(game1, player1);
            Console.WriteLine("---------------- campaign kismi --------------");
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                name="indirim1",
                rate=0.9
            };
            Campaign campaign2 = new Campaign
            {
                Id = 2,
                name = "indirim2",
                rate = 0.5
            };
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            foreach (Campaign campaign in campaignManager.campaigns)
            {
                Console.WriteLine( campaign.Id +" "+campaign.name + " " + campaign.rate);
            }
            Console.WriteLine("-------------- campagin 2 silme ----------------");
            campaignManager.Delete(campaign2);
            foreach (Campaign campaign in campaignManager.campaigns)
            {
                Console.WriteLine(campaign.name + " " + campaign.rate);
            }
            Campaign campaign3 = new Campaign
            {
                Id = 1,
                name = "indirim12",
                rate = 0.4
            };
            Console.WriteLine("--------------- update campagin 1 ------------------- ");
            campaignManager.Update(campaign3);
            foreach (Campaign campaign in campaignManager.campaigns)
            {
                Console.WriteLine( campaign.Id +" "+ campaign.name + " " + campaign.rate);
            }
            Console.WriteLine("---------- sell with campagin -------------");
            gameManager.SellGameWithCamp(game1, player5, campaign1);
            Console.WriteLine(" ---------------------- ");
            playerManager.Add(player5);
        }
    }
}
