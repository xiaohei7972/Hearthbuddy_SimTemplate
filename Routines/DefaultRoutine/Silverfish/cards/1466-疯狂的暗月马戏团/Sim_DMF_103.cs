using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_103 : SimTemplate //* 克苏恩面具 Mask of C'Thun
	{
        //Deal $10 damage randomly split among all enemies.
        //造成$10点伤害，随机分配到所有敌人身上。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if(p.enemyMinions.Count == 0)
            {
                p.minionGetDamageOrHeal(p.enemyHero, p.getSpellDamageDamage(10));
            }else
            {
                p.allMinionOfASideGetDamage(false, 2);
            }
        }

    }
}
