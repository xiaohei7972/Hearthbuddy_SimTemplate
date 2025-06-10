using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_010 : SimTemplate //* 夜魇骑士 Nightbane Templar
	{
		//<b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
		//<b>战吼：</b>如果你的手牌中有龙牌，便召唤两条1/1的雏龙。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_010a);
		
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
					p.callKid(kid, own.zonepos, own.own);
					p.callKid(kid, own.zonepos, own.own);
				}
			}
			else
			{
                if (p.enemyAnzCards > 1)
				{
					p.callKid(kid, own.zonepos, own.own);
					p.callKid(kid, own.zonepos, own.own);
				}
			}
        }
    }
}
