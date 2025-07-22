using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：4 攻击力：3 耐久度：0
	//Umpire's Grasp
	//裁判拳套
	//<b>Deathrattle:</b> Draw a Demon and reduceits Cost by (2).
	//<b>亡语：</b>抽一张恶魔牌，并使其法力值消耗减少（2）点。
	class Sim_TOY_641 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_641);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (var cardEntry in p.prozis.turnDeck)
			{
				CardDB.Card card = CardDB.Instance.getCardDataFromID(cardEntry.Key);
				if (card.type == CardDB.cardtype.MOB && (CardDB.Race)card.race == CardDB.Race.DEMON)
				{
					p.drawACard(cardEntry.Key, m.own);
					//TODO 还没写减费效果
					break;
				}
			}


		}

	}
}
