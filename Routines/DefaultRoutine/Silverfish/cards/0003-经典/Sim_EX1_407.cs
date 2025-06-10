using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_407 : SimTemplate //* 绝命乱斗 Brawl
	{
		//Destroy all minions except one. <i>(chosen randomly)</i>
		//随机选择一个随从，消灭除了该随从外的所有其他随从。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            bool hasWinner = false;
            foreach (Minion m in p.enemyMinions)
            {
                if ((m.name == CardDB.cardNameEN.darkironbouncer || m.name == CardDB.cardNameEN.corendirebrew) && !hasWinner)
                {
                    hasWinner = true;
                    continue;
                }
                p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                if ((m.name == CardDB.cardNameEN.darkironbouncer || m.name == CardDB.cardNameEN.corendirebrew) && !hasWinner)
                {
                    hasWinner = true;
                    continue;
                }
                p.minionGetDestroyed(m);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 2),
            };
        }
	}
}