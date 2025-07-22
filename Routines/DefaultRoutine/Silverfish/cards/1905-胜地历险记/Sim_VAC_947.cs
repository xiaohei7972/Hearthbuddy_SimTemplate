using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：5
	//Wave Pool Thrasher
	//波池造浪者
	//<b>Battlecry:</b> Give allother minions -1/-1.<b>Deathrattle:</b> Give allother minions +1/+1.
	//<b>战吼：</b>使所有其他随从获得-1/-1。<b>亡语：</b>使所有其他随从获得+1/+1。
	class Sim_VAC_947 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 使所有其他随从获得-1/-1
            foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID != own.entitiyID)
                {
                    p.minionGetBuffed(m, -1, -1);
                }
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.entitiyID != own.entitiyID)
                {
                    p.minionGetBuffed(m, -1, -1);
                }
            }
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 使所有其他随从获得+1/+1
            foreach (Minion minion in p.ownMinions)
            {
                if (minion.entitiyID != m.entitiyID)
                {
                    p.minionGetBuffed(minion, 1, 1);
                }
            }
            foreach (Minion minion in p.enemyMinions)
            {
                if (minion.entitiyID != m.entitiyID)
                {
                    p.minionGetBuffed(minion, 1, 1);
                }
            }
        }


    }
}
