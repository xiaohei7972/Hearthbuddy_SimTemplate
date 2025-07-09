using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：6 攻击力：2 生命值：8
	//Gorishi Wasp
	//格里什异种虫
	//Whenever this takes damage, get a 1-Cost Gorishi Stinger.
	//每当本随从受到伤害，获取一张法力值消耗为（1）的格里什毒刺虫。
	class Sim_TLC_630 : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
		{
			if (triggerEffectMinion.anzGotDmg > 0)
			{
				int tmp = triggerEffectMinion.anzGotDmg;
				triggerEffectMinion.anzGotDmg = 0;
				for (int i = 0; i < tmp; i++)
				{
					p.drawACard(CardDB.cardIDEnum.TLC_630t, triggerEffectMinion.own, true);
				}

			}
		}

	}
}
