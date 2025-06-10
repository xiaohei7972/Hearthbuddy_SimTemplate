using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 战士 费用：3 攻击力：4 耐久度：1
	//Battlepickaxe
	//矿镐战斧
	//After you play a<b>Taunt</b> minion, gain +1_Durability.
	//在你使用一张<b>嘲讽</b>随从牌后，获得+1耐久度。
	class Sim_WW_347 : SimTemplate
	{
		//CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_347);
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_347);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card,ownplay);
		}
		
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (wasOwnCard == triggerEffectMinion.own && hc.card.tank)
			{
				p.ownWeapon.Durability++;
			}
		}

	}
}
