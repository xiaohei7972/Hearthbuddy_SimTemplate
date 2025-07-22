using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：1 攻击力：1 耐久度：0
	//Tuskpiercer
	//獠牙锥刃
	//[x]<b>Deathrattle:</b> Draw a<b>Deathrattle</b> minion.
	//<b>亡语：</b>抽一张<b>亡语</b>随从牌。
	class Sim_CORE_BAR_330 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CORE_BAR_330);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			foreach (var cardEntry in p.prozis.turnDeck)
			{
				CardDB.Card card = CardDB.Instance.getCardDataFromID(cardEntry.Key);
				if (card.deathrattle == true)
				{
					p.drawACard(cardEntry.Key, m.own);
					break;
				}
			}
		}
		
	}
}
