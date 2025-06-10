using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_818 : SimTemplate //* 不稳定的元素 Volatile Elemental
//<b>Deathrattle:</b> Deal 3 damage to a random enemy minion.
//<b>亡语：</b>随机对一个敌方随从造成3点伤害。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            Minion target = null;
            if (m.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(3, true);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
            }
            if (target != null) p.minionGetDamageOrHeal(target, 3);
        }
    }
}