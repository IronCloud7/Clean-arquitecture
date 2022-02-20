using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Estructura._2_Interface_Adapter.Hero
{
    public interface UpdaterMove
    {
        public void UpdateMove(HeroOutputData heroOutputData);
    }
}
