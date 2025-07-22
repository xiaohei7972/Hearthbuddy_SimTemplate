using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_937 : SimTemplate //* 蛮鱼斥候 Primalfin Lookout
//<b>Battlecry:</b> If you control another Murloc, <b>Discover</b> a_Murloc.
//<b>战吼：</b>如果你控制其他任何鱼人，则<b>发现</b>一张鱼人牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.entitiyID == own.entitiyID) continue;
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MURLOC)
				{
					p.drawACard(CardDB.cardNameEN.bluegillwarrior, own.own, true);
					break;
				}
            }
		}
	}
}