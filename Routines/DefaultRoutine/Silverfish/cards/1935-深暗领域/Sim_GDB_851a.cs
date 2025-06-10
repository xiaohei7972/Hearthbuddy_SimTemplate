using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_851a : SimTemplate //* 致命射线 Lethal Rays
	{
		//Deal 2 damage to two random enemy minions.
		//随机对两个敌方随从造成2点 伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            List<Minion> temp2 = new List<Minion>(p.enemyMinions);
            temp2.Sort((a, b) => a.Hp.CompareTo(b.Hp));
            int i = 0;
            foreach (Minion enemy in temp2)
            {
                p.minionGetDamageOrHeal(enemy, damage);
                i++;
                if (i == 2) break;
            }
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1), // 需要至少一个敌方随从
            };
        }
	}
}