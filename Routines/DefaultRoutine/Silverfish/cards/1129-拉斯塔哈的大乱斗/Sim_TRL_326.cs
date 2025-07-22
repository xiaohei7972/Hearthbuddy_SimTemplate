using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_326 : SimTemplate //* 燃棘枪兵 Smolderthorn Lancer
//<b>Battlecry:</b> If you're holding a Dragon, destroy a damaged enemy minion.
//<b>战吼：</b>如果你的手牌中有龙牌，则消灭一个受伤的敌方随从。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(own.own)
			{
				bool dragonInHand = false;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
					{
						dragonInHand = true;
						break;
					}
				}
				if(dragonInHand)
				{
					p.minionGetDestroyed(target);
				}
			}
			else
			{
				if (p.enemyAnzCards >= 2)
				{
					p.minionGetDestroyed(target);
                }					
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}