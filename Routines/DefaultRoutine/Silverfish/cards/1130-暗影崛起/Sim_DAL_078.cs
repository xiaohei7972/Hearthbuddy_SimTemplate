using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_078 : SimTemplate //* 旅行医者 Traveling Healer
//[x]<b>Divine Shield</b><b>Battlecry:</b> Restore #3 Health.
//<b>圣盾，战吼：</b>恢复#3点生命值。 
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