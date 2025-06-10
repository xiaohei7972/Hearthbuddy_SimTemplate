using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_133 : SimTemplate //* 鹿角小飞兔 Wolpertinger
	{
		//<b>Battlecry:</b> Summon a copy of this.
		//<b>战吼：</b>召唤一个该随从的复制。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(p.ownMinions.Count < 7)
            {
				p.callKid(m.handcard.card, m.zonepos, m.own);
				List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
				temp[m.zonepos].setMinionToMinion(m);
			}
		}
		
		
	}
}
