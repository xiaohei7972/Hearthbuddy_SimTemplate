using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_114 : SimTemplate //* 顺劈斩 Cleave
	{
		//[x]Deal $2 damage totwo random enemyminions.
		//随机对两个敌方随从造成$2点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            //TODO delete new list
            int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            List<Minion> temp2 = (ownplay) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions) ;
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
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}