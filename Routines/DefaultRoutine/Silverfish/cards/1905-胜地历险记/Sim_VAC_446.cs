using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：0 生命值：5
	//A. F. Kay
	//挂机的阿凯
	//[x]At the end of your turn,give all other friendlyminions that didn'tattack +2/+2.
	//在你的回合结束时，使所有其他未攻击的友方随从获得+2/+2。
	class Sim_VAC_446 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 检查是否是自己的回合结束
            if (turnEndOfOwner && m.own)
            {
                // 遍历所有其他友方随从
                foreach (Minion minion in p.ownMinions)
                {
                    // 排除当前的随从自身，并检查该随从是否未攻击
                    if (minion.entitiyID != m.entitiyID && minion.allreadyAttacked)
                    {
                        // 给未攻击的随从增加+2/+2
                        p.minionGetBuffed(minion, 2, 2);
                    }
                }
            }
        }
    }
}
