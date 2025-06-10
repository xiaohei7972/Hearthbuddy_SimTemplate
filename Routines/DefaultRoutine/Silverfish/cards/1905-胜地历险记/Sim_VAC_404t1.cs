using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：1
	//Nightshade Tea
	//夜影花茶
	//Deal $2 damageto a minion. Deal $2 damage to your hero.<i>(2 Drinks left!)</i>
	//对一个随从造成$2点伤害。对你的英雄造成$2点伤害。<i>（还剩2杯！）</i>
	class Sim_VAC_404t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);

            // 对一个随从造成2点伤害
            p.minionGetDamageOrHeal(target, dmg);

            // 对你的英雄造成2点伤害
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, dmg);

            // 抽一张 "VAC_404t2" 卡牌，表示“最后一杯”
            p.drawACard(CardDB.cardIDEnum.VAC_404t2, ownplay, true);
        }
    }
}
