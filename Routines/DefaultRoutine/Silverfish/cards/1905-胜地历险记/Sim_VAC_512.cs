using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：1 攻击力：2 生命值：4
	//Brain Masseuse
	//心灵按摩师
	//[x]Whenever this minion takesdamage, also deal thatamount to your hero.
	//每当本随从受到伤害，对你的英雄造成等量的伤害。
	class Sim_VAC_512 : SimTemplate
	{
        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                m.anzGotDmg = 0;
                p.minionGetDamageOrHeal(m.own ? p.ownHero : p.enemyHero, m.GotDmgValue);
            }
        }
    }
}
