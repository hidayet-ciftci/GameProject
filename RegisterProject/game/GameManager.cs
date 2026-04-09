using RegisterProject.campaign1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.game
{
    public class GameManager
    {
        public void SellGame(Game game,Players player)
        {
            Console.WriteLine(player.Ad+" "+player.Soyad+ " " + game.Name + " oyununu " + game.Price + " fiyatina satin aldi");
        }
        public void SellGameWithCamp(Game game, Players player, Campaign campaign)
        {
            double NewPrice = game.Price * campaign.rate;
            Console.WriteLine(player.Ad + " " + player.Soyad+ " " + game.Name + " oyununu " + NewPrice + " fiyatina satin aldi");
        }
    }
}
