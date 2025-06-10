using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_094 : SimTemplate //* 火焰杂耍者 Flame Juggler
//<b>Battlecry:</b> Deal 1 damage to a random enemy.
//<b>战吼：</b>随机对一个敌人造成1点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(1);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, 1);
        }
    }
}