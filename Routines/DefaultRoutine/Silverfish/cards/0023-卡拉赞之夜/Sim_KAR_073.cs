using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_073 : SimTemplate //* 大漩涡传送门 Maelstrom Portal
//Deal_$1_damage to_all_enemy_minions. Summon_a_random1-Cost minion.
//对所有敌方随从造成$1点伤害。随机召唤一个法力值消耗为（1）的随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
			
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getRandomCardForManaMinion(1), pos, ownplay);
		}
	}
}