using RegisterProject.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RegisterProject
{
    public interface IRegisterSystem<T>
    {
        void Add(T clas);
        void Delete(T clas);
        void Update(T clas);
    }
}
