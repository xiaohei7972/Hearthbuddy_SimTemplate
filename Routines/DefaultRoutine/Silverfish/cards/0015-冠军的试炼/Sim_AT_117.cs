using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_117 : SimTemplate //* 庆典司仪 Master of Ceremonies
//<b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
//<b>战吼：</b>如果你控制任何具有<b>法术伤害</b>的随从，便获得+2/+2。 
    {
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp  = (own.own) ? p.ownMinions : p.enemyMinions;
            int gain = 0;
            foreach (Minion m in temp)
            {
                if (m.spellpower > 0) gain++;
            }
            if(gain>=1) p.minionGetBuffed(own, gain*2, gain*2);
        }
    }
}