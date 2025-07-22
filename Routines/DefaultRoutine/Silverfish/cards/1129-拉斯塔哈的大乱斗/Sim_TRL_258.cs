using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_258 : SimTemplate //* 群体狂乱 Mass Hysteria
//Force each minion to_attack another random minion.
//使每个随从随机攻击其他随从。 
	{
        

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
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}