using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_521 : SimTemplate //* 胁迫 Coerce
	{
		//Destroy a damaged minion. <b>Combo:</b> Destroy any minion.
		//消灭一个受伤的随从。<b>连击：</b>消灭任意随从。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			foreach (var m in p.enemyMinions)
			{
				if (m.wounded) p.minionGetDestroyed(m);

				if (p.cardsPlayedThisTurn >= 1 && target != null && ownplay)
				{
					p.minionGetDestroyed(target);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
            };
        }
	}
}
