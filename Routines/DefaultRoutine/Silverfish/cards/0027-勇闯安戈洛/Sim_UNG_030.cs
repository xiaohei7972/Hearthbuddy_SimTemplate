using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_030 : SimTemplate //* 联结治疗 Binding Heal
//Restore #5 Health to a minion and your hero.
//为你的英雄和一个随从恢复#5点生命值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
			
            if (target != null) p.minionGetDamageOrHeal(target, -heal);
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