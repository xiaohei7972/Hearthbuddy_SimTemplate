using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Summoning Ward
	//召唤结界
	//[x]<b>Secret:</b> When your turnstarts, summon a copy ofyour highest Cost minion.
	//<b>奥秘：</b>当你的回合开始时，召唤你法力值消耗最高的随从的一个复制。
	class Sim_DEEP_000 : SimTemplate
	{
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool ownTurn)
        {
            // 仅当是玩家自己的回合时触发效果
            if (ownTurn)
            {
                Minion highestCostMinion = null; // 用于存储法力值消耗最高的随从
                int highestCost = -1; // 初始化为-1，确保任何随从都会覆盖这个值

                // 遍历所有玩家自己的随从，寻找法力值消耗最高的随从
                foreach (Minion m in p.ownMinions)
                {
                    if (m.handcard.card.cost > highestCost)
                    {
                        highestCost = m.handcard.card.cost; // 更新最高法力值消耗
                        highestCostMinion = m; // 更新对应的随从
                    }
                }

                // 如果找到了最高法力值消耗的随从，则召唤它的一个复制
                if (highestCostMinion != null)
                {
                    p.callKid(highestCostMinion.handcard.card, highestCostMinion.zonepos, true);
                }
            }
        }
    }
}
