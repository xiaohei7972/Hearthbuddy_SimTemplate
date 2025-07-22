using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：1 生命值：4
	//Acolyte of Pain
	//苦痛侍僧
	//Whenever this minion takes damage, draw a_card.
	//每当本随从受到伤害，抽一张牌。
	class Sim_WON_357 : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
		{
			if (triggerEffectMinion.anzGotDmg > 0)
			{
				int tmp = triggerEffectMinion.anzGotDmg;
				triggerEffectMinion.anzGotDmg = 0;
				for (int i = 0; i < tmp; i++)
				{
					p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
				}
			}
		}
		
	}
}
