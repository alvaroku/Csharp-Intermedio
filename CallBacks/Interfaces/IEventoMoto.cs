using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBacks.Interfaces
{
    public interface IEventoMoto
    {
        public void CombustibleBajo(float Gas);
        public void Beep();
    }
}
