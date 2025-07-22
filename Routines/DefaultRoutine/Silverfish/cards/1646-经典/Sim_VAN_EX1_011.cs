using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_011 : SimTemplate //* 巫医 Voodoo Doctor
	{
		//<b>Battlecry:</b> Restore #2_Health.
		//<b>战吼：</b>恢复#2点生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int heal = (own.own) ? p.getMinionHeal(2) : p.getEnemyMinionHeal(2);
            p.minionGetDamageOrHeal(target, -heal);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}