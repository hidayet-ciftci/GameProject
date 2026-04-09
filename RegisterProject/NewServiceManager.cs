using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject
{
    public class NewServiceManager : IPlayerValidationService
    {
        public bool validate(Players players)
        {
            Console.WriteLine("Dogrulama basarili");
            return true;
        }
    }
}
