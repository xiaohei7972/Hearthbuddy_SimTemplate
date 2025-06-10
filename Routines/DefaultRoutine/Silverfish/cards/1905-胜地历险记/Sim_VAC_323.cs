using System;
using System.Collections.Generic;
using System.Text;
using HREngine.Bots;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Malted Magma
	//麦芽岩浆
	//Deal $1 damageto all enemies.<i>(3 Drinks left!)</i>
	//对所有敌人造成$1点伤害。<i>（还剩3杯！）</i>
	class Sim_VAC_323 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allCharsOfASideGetDamage(!ownplay, dmg); // 对所有敌人造成1点伤害

            // 抽一张“还剩2杯”的卡牌
            p.drawACard(CardDB.cardIDEnum.VAC_323t, ownplay, true);
        }
    }
}
