using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_265 : SimTemplate //* 乌祖尔巨人 urzulgiant
	{
		//在本局对战中每有一个友方随从死亡，该牌的法力值消耗就减少（1）点。
        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            if (m.own == diedMinion.own)
            {
                int diedMinions = m.own ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
                if (diedMinions != 0)
                {
                    int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
                    m.pID = p.pID;
                    m.extraParam2 = diedMinions;
                    m.handcard.card.cost -= 1;
                }
            }            
        }		
	}
}
