using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：1
	//Seabreeze Chalice
	//银樽海韵
	//[x]Deal $2 damage randomlysplit among all enemies.<i>(Last Drink!)</i>
	//造成$2点伤害，随机分配到所有敌人身上。<i>（最后一杯！）</i>
	class Sim_VAC_520t2 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allCharsOfASideGetRandomDamage(!ownplay, dmg); // 随机分配2点伤害到所有敌人身上
        }
    }
}
