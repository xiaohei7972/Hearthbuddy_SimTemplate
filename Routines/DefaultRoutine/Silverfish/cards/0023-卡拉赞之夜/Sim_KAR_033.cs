using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_033 : SimTemplate //* 书卷之龙 Book Wyrm
//<b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
//<b>战吼：</b>如果你的手牌中有龙牌，则消灭一个攻击力小于或等于3的敌方随从。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(m.own)
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
					if (target!= null) p.minionGetDestroyed(target);
                }
			}
			else
			{
				if (p.enemyAnzCards >= 2)
				{
					if (target!= null) p.minionGetDestroyed(target);
                }					
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 3),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
            };
        }
    }
}