using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_165 : SimTemplate //* 裂隙屠夫 Riftcleaver
//<b>Battlecry:</b> Destroy a minion. Your hero takes damage equal to its Health.
//<b>战吼：</b>消灭一个随从。你的英雄受到等同于该随从生命值的伤害。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null)
			{						
				p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, target.Hp);
				p.minionGetDestroyed(target);
			}
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