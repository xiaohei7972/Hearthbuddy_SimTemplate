using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_008b : SimTemplate //* 古老的秘密 Ancient Secrets
	{
		//Restore 5 Health.
		//恢复5点生命值。
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
            p.minionGetDamageOrHeal(target, -heal);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}