using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：2 生命值：6
	//Alloy Advisor
	//合金顾问
	//<b>Taunt</b>Whenever this takes damage, gain 3 Armor.
	//<b>嘲讽</b>每当本随从受到伤害，获得3点护甲值。
	class Sim_WORK_023 : SimTemplate
	{
		public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.own)
            {
                for (int i = 0; i < anzOwnMinionsGotDmg - anzOwnHeroGotDmg; i++)
                {
					p.minionGetArmor(p.ownHero, 3);
                }
            }
            else
            {
                for (int i = 0; i < anzEnemyMinionsGotDmg - anzEnemyHeroGotDmg; i++)
                {
                    p.minionGetArmor(p.enemyHero, 3); // 敌方英雄获得护甲
                }
            }
		}
	}
}
