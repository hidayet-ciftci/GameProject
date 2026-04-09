using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject
{
    public interface IPlayerValidationService
    {
        bool validate(Players players);
    }
}
