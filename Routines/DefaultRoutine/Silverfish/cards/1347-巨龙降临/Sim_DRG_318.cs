using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_318 : SimTemplate //* 梦境吐息 Breath of Dreams
	{
		//Draw a card. If you're holding a Dragon, gain an empty Mana Crystal.
		//抽一张牌。如果你的手牌中有龙牌，便获得一个空的法力水晶。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			if (ownplay)
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
				if (dragonInHand)
				{
					if (p.ownMaxMana < 10)
					{
						p.ownMaxMana++;
					}
				}
			}
		}
	}
}