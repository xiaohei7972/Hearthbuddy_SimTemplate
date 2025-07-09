using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：2 攻击力：0 生命值：6
	//Steadfast Security
	//坚毅的守卫
	//<b>Taunt</b>After this takes damage, gain +1 Attack.
	//<b>嘲讽</b>在本随从受到伤害后，获得+1攻击力。
	class Sim_TLC_622t : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
		{
			if (triggerEffectMinion.anzGotDmg > 0)
			{
				int tmp = triggerEffectMinion.anzGotDmg;
				triggerEffectMinion.anzGotDmg = 0;
				for (int i = 0; i < tmp; i++)
				{
					p.minionGetBuffed(triggerEffectMinion, 1, 0);
				}

			}
		}

	}
}
