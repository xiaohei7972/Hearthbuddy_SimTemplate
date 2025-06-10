using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_302 : SimTemplate //* 渡魂者 Usher of Souls
//Whenever a friendly minion dies, give your C'Thun +1/+1<i>(wherever it is).</i>
//每当一个友方随从死亡时，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i> 
	{
		
		
        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = p.tempTrigger.ownMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            p.cthunGetBuffed(residual, residual, 0);
        }
	}
}