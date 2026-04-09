using RegisterProject.campaign1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.game
{
    public interface IGameService
    {
        void SellGame(Game game, Players player);
        void SellGameWithCamp(Game game, Players player, Campaign campaign);
    }
}
