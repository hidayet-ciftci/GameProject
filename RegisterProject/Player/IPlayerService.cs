using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject.Player
{
    public interface IPlayerService
    {
        void Add(Players players);
        void Delete(Players players);
        void Update(Players players);
    }
}
