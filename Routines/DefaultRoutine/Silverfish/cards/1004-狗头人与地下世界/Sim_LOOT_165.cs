using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_165 : SimTemplate //* 影舞者索尼娅 Sonya Shadowdancer
//After a friendly minion dies, add a 1/1 copy of it to your hand. It costs (1).
//在一个友方随从死亡后，将它的1/1复制置入你的手牌，其法力值消耗变为（1）点。 
	{
        

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            int diedMinions = (m.own) ? p.tempTrigger.ownMinionsDied : p.tempTrigger.enemyMinionsDied;
            if (diedMinions == 0) return;
            int residual = (p.pID == m.pID) ? diedMinions - m.extraParam2 : diedMinions;
            m.pID = p.pID;
            m.extraParam2 = diedMinions;
            for (int i = 0; i < residual; i++)
            {
                p.drawACard(p.revivingOwnMinion, m.own, true);
            }
        }
	}
}