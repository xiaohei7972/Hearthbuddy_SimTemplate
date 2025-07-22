using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
	class Sim_DRG_059 : SimTemplate //* 地精滑翔技师 Goboglide Tech
	{
		//<b>Battlecry:</b> If you control a Mech, gain +1/+1 and <b>Rush</b>.
		//<b>战吼：</b>如果你控制一个机械，便获得+1/+1和<b>突袭</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
				if (m.entitiyID == own.entitiyID) continue;
				if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
				{
					p.minionGetBuffed(own, 1, 1);
					p.minionGetRush(m);
				}
			}
		}
	}
}