using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_860 : SimTemplate //* 辰鳞星圣 
	{
        //<b><b>Spellburst</b>:</b> Double this minion's Attack.
        //<b><b>法术迸发</b>：</b>本随从的攻击力翻倍。
        public override void OnSpellburst(Playfield p, Minion m, Handmanager.Handcard hc)
        {
            p.minionGetBuffed(m, m.Angr, 0);
        }
    }
}
