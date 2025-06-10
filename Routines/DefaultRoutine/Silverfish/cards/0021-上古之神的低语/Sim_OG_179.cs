using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_179 : SimTemplate //* 炽炎蝙蝠 Fiery Bat
//<b>Deathrattle:</b> Deal 1 damage to a random enemy.
//<b>亡语：</b>随机对一个敌人造成1点伤害。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            Minion target = null;

            if (m.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(1);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchLowestHP); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, 1);
        }
    }
}