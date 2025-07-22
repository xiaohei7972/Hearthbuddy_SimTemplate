using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_251 : SimTemplate //* 叉状闪电 Forked Lightning
	{
		//Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2)
		//随机对两个敌方随从造成$2点伤害，<b>过载：</b>（2）
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
            if (ownplay) p.ueberladung += 2;
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
            };
        }
	}
}