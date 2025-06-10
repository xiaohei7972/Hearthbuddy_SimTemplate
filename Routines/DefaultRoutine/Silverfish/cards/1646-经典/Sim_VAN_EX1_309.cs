using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_309 : SimTemplate //* 灵魂虹吸 Siphon Soul
	{
		//Destroy a minion. Restore #3 Health to_your hero.
		//消灭一个随从，为你的英雄恢复#3点生命值。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDestroyed(target);
            int heal = (ownplay) ? p.getSpellHeal(3) : p.getEnemySpellHeal(3);

            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -heal);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
