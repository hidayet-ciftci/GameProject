using RegisterProject.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject
{
    public class PlayerValidationManager : IPlayerValidationService
    {
        public bool validate(Players players)
        {
            if (players.TcNo == "111") { Console.WriteLine(" Tc No yanlis"); return false; }
            else
            {
                Console.WriteLine("dogrulama basarili");
                return true;
            }
        }
    }
}
