using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_213 : SimTemplate //* 双头暴虐龙 Twin Tyrant
	{
		//<b>Battlecry:</b> Deal 4 damage to two random enemy minions.
		//<b>战吼：</b>随机对两个敌方随从造成4点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int damage = (own.own) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
			List<Minion> temp2 = (own.own) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
			temp2.Sort((a, b) => -a.Hp.CompareTo(b.Hp));
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