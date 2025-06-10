using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Seabreeze Chalice
	//银樽海韵
	//[x]Deal $2 damage randomlysplit among all enemies.<i>(3 Drinks left!)</i>
	//造成$2点伤害，随机分配到所有敌人身上。<i>（还剩3杯！）</i>
	class Sim_VAC_520 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allCharsOfASideGetRandomDamage(!ownplay, dmg); // 随机分配2点伤害到所有敌人身上

            // 触发“还剩3杯”的效果，抽一张指定卡牌
            p.drawACard(CardDB.cardIDEnum.VAC_520t, ownplay, true); // 抽一张 "VAC_520t" 卡牌
        }
    }
}
