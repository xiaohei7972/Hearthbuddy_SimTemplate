using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_039 : SimTemplate //* A3型机械金刚 Gorillabot A-3
//<b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
//<b>战吼：</b>如果你控制其他任何机械，则<b>发现</b>一张机械牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
				{
					p.drawACard(CardDB.cardNameEN.spidertank, own.own, true);
					break;
				}
            }
		}
	}
}