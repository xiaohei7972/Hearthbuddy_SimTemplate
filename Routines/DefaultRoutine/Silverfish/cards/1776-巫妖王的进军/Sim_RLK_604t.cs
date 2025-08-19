using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：21 攻击力：0 生命值：1
	//Phoenix Egg
	//凤凰蛋
	//<b>Dormant</b>Cast a Fire spell torevive Thori'belore!
	//<b>休眠</b>施放一个火焰法术以复活索利贝洛尔！
	class Sim_RLK_604t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_604);

		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
		{
			if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL && hc.card.SpellSchool == CardDB.SpellSchool.FIRE)
			{
				p.callKid(kid, triggerEffectMinion.zonepos - 1, triggerEffectMinion.own);
				p.RemoveMinionWithoutDeathrattle(triggerEffectMinion);
			}
		}

	}
}
