using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_275 : SimTemplate //* 冰锥术 Cone of Cold
	{
		//<b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them.
		//<b>冻结</b>一个随从和其相邻的随从，并对它们造成$1点伤害。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetFrozen(target);
            List<Minion> temp = (target.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (target.zonepos == m.zonepos + 1 || target.zonepos + 1 == m.zonepos)
                {
                    p.minionGetDamageOrHeal(m, dmg);
                    p.minionGetFrozen(m);
                }
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}