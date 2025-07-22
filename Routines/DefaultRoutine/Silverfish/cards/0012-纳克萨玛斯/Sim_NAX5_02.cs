using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX5_02 : SimTemplate //* 爆发 Eruption
//<b>Hero Power</b>Deal 2 damage to the left-most enemy minion.
//<b>英雄技能</b>对位于最左边的敌方随从造成2点伤害。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            if (temp.Count < 1) return;
            else
			{
				int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				target = temp[0];
				foreach (Minion m in temp)
				{
					if (m.zonepos < target.zonepos) target = m;
				}
				p.minionGetDamageOrHeal(target, dmg);
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