using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：3 生命值：5
	//Broll Bearmantle
	//布罗尔·熊皮
	//After you cast a spell, summon a randomAnimal Companion.
	//在你施放一个法术后，随机召唤一个动物伙伴。
	class Sim_EDR_853 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
			if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
			{
				p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
			}
        }
		
	}
}
