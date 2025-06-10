using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_913: SimTemplate //* 被污染的狂热者 Tainted Zealot
//<b>Divine Shield</b><b>Spell Damage +1</b>
//<b>圣盾</b><b>法术伤害+1</b> 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.spellpower++;
            else p.enemyspellpower++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.spellpower--;
            else p.enemyspellpower--;
        }
    }
}