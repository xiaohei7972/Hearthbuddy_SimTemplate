using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_528 : SimTemplate //* 暮光侍僧 Twilight Acolyte
//<b>Battlecry:</b> If you're holdinga Dragon, swap this minion's Attack with another minion's.
//<b>战吼：</b>如果你的手牌中有龙牌，则将此随从的攻击力与另一个随从交换。 
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
					if (target == null) return;
					
					m.Angr = target.Angr;
					target.Angr = m.Angr;				
                }
			}
			else
			{
				if (p.enemyAnzCards >= 2)
				{
					if (target == null) return;
					
					m.Angr = target.Angr;
					target.Angr = m.Angr;
                }					
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}