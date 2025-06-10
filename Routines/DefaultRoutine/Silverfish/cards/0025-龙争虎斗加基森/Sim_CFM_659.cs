using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_659 : SimTemplate //* 加基森名媛 Gadgetzan Socialite
//<b>Battlecry:</b> Restore #2_Health.
//<b>战吼：</b>恢复#2点生命值。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                int heal = (m.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
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