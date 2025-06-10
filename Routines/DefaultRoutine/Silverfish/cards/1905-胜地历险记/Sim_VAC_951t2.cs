using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//"Health" Drink
	//“健康”饮品
	//<b>Lifesteal</b>. Deal $3 damage to a minion.<i>(Last Drink!)</i>
	//<b>吸血</b>对一个随从造成$3点伤害。<i>（最后一杯！）</i>
	class Sim_VAC_951t2 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            // 对一个随从造成3点伤害并触发吸血效果
            p.minionGetDamageOrHeal(target, damage);
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -damage);
        }
    }
}
