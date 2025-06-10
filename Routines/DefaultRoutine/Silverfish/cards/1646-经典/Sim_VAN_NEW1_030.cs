using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_030 : SimTemplate //* 死亡之翼 Deathwing
	{
		//<b>Battlecry:</b> Destroy all other minions and discard your_hand.
		//<b>战吼：</b>消灭所有其他随从，并弃掉你的手牌。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID != own.entitiyID) p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.entitiyID != own.entitiyID) p.minionGetDestroyed(m);
            }
            p.discardCards(10, own.own);
		}
	}
}