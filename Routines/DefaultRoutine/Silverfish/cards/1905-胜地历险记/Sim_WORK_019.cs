using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：5 攻击力：3 生命值：7
	//Cash Cow
	//摇钱金牛
	//[x]<b>Taunt</b>Whenever this takesdamage, get a Coin.
	//<b>嘲讽</b>。每当本随从受到伤害，获取一张幸运币。
	class Sim_WORK_019 : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
		{
			if (triggerEffectMinion.anzGotDmg > 1)
			{
				int tmp = triggerEffectMinion.anzGotDmg;
				triggerEffectMinion.anzGotDmg = 0;
				for (int i = 0; i < tmp; i++)
				{
					p.drawACard(CardDB.cardIDEnum.GAME_005, triggerEffectMinion.own, true);
				}
			}

		}

	}
}
