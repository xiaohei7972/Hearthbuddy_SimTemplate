using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：3 攻击力：2 生命值：5
	//Sludge on Wheels
	//轮式淤泥怪
	//[x]<b>Rush</b>. Whenever this takesdamage, get a Barrel ofSludge and add one to thebottom of your deck.
	//<b>突袭</b>。每当本随从受到伤害时，获取一张淤泥桶并将一张淤泥桶置于你的牌库底。
	class Sim_WW_043 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_044t);
		public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
		{
			if (triggerEffectMinion.anzGotDmg > 0)
			{
				int tmp = triggerEffectMinion.anzGotDmg;
				triggerEffectMinion.anzGotDmg = 0;
				for (int i = 0; i < tmp; i++)
				{
					p.drawACard(CardDB.cardIDEnum.WW_044t, triggerEffectMinion.own, true);
					p.AddToDeck(card);
				}
			}
		}

	}
}
