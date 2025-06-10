using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_086 : SimTemplate //* 阴暗的酒保 Shady Bartender
	{
		//<b>Tradeable</b><b>Battlecry:</b> Give your Demons +2/+2.
		//<b>可交易</b><b>战吼：</b>使你的所有恶魔获得+2/+2。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp)
            {
                if ((TAG_RACE)mnn.handcard.card.race == TAG_RACE.DEMON && mnn.entitiyID != m.entitiyID) p.minionGetBuffed(mnn, 2, 2);
            }
        }
		
	}
}
