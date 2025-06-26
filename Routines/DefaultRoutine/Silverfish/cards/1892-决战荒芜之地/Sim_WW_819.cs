using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：2 攻击力：2 生命值：1
	//Splish-Splash Whelp
	//戏水雏龙
	//<b>Battlecry:</b> If you're holding a Dragon, gain an empty Mana Crystal.
	//<b>战吼：</b>如果你的手牌中有龙牌，获得一个空的法力水晶。
	class Sim_WW_819 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
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
				p.ownMaxMana = Math.Max(10, p.ownMaxMana++);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_OF_RACE_IN_HAND,24), //手牌里有龙
			};
        }
		
	}
}
