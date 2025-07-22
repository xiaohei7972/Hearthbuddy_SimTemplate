using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：4 生命值：6
	//Forgotten Animatronic
	//废弃电子玩偶
	//At the end of your turn, destroy a minion with less Attack than this.
	//在你的回合结束时，消灭一个攻击力低于本随从的随从。
	class Sim_TOY_820 : SimTemplate
	{

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == m.own)
            {
                Minion targetToDestroy = null;

                // 遍历所有敌方和己方随从，寻找攻击力低于本随从的随从
                foreach (Minion minion in p.enemyMinions)
                {
                    if (minion.Angr < m.Angr)
                    {
                        targetToDestroy = minion;
                        break;
                    }
                }

                if (targetToDestroy == null)
                {
                    foreach (Minion minion in p.ownMinions)
                    {
                        if (minion.Angr < m.Angr && minion.entitiyID != m.entitiyID)
                        {
                            targetToDestroy = minion;
                            break;
                        }
                    }
                }

                // 如果找到了符合条件的随从，则将其消灭
                if (targetToDestroy != null)
                {
                    p.minionGetDestroyed(targetToDestroy);
                }
            }
        }

    }
}
