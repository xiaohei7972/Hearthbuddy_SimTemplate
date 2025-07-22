using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_551 : SimTemplate //* 骄傲的防御者 Proud Defender
//<b>Taunt</b>Has +2 Attack while you [x]have no other minions.
//<b>嘲讽</b>如果你没有其他随从，则具有+2攻击力。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            int mCount = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (mCount < 0) p.minionGetBuffed(m, 2, 0);
        }
    }
}