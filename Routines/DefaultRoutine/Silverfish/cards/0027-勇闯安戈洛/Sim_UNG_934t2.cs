using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_934t2 : SimTemplate //* 死吧，虫子！ DIE, INSECT!
//<b>Hero Power</b>Deal $8 damage to a random enemy.
//<b>英雄技能</b>随机对一个敌人造成$8点伤害。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(8) : p.getEnemyHeroPowerDamage(8);
            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg, true);
        }
	}
}