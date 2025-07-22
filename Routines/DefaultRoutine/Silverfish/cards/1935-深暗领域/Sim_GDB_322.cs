using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_322 : SimTemplate //* 光注魔刃豹 
	{
        //<b>Rush</b> <b><b>Spellburst</b>:</b> Gain <b>Divine Shield</b>.
        //<b>突袭</b>。<b><b>法术迸发</b>：</b>获得<b>圣盾</b>。
        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            m.divineshild = true;
        }
    }
}
