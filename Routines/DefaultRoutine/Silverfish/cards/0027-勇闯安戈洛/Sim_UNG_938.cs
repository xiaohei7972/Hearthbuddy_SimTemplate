using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_938 : SimTemplate //* 温泉守卫 Hot Spring Guardian
//<b>Taunt</b><b>Battlecry:</b> Restore #3_Health.
//<b>嘲讽，战吼：</b>恢复#3点生命值。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (target != null)
			{
				int heal = (own.own) ? p.getMinionHeal(3) : p.getEnemyMinionHeal(3);
				p.minionGetDamageOrHeal(target, -heal);
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}