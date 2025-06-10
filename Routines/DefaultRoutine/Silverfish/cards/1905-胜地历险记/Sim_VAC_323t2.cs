using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Malted Magma
	//麦芽岩浆
	//Deal $1 damageto all enemies.<i>(Last Drink!)</i>
	//对所有敌人造成$1点伤害。<i>（最后一杯！）</i>
	class Sim_VAC_323t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allCharsOfASideGetDamage(!ownplay, dmg); // 对所有敌人造成1点伤害
        }
    }
}
