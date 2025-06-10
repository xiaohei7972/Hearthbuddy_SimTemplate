using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_047 : SimTemplate //* 德莱尼图腾师 Draenei Totemcarver
//<b>Battlecry:</b> Gain +1/+1 for each friendly Totem.
//<b>战吼：</b>每有一个友方图腾，便获得+1/+1。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int gain = 0;
            List<Minion> temp  = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.TOTEM) gain++;
            }
            if(gain >= 1) p.minionGetBuffed(own, gain, gain);
		}
	}
}