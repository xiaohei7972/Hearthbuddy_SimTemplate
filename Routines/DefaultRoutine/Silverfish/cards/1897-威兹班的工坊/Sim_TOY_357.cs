using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：9 攻击力：6 生命值：6
	//King Plush
	//抱龙王噗鲁什
	//[x]<b>Charge</b><b>Battlecry:</b> Return all minionswith less Attack than this_to their owner's decks.
	//<b>冲锋</b><b>战吼：</b>将所有攻击力小于本随从的随从移回其拥有者的牌库。
	class Sim_TOY_357 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int attackThreshold = own.Angr; // 获取本随从的攻击力

            // 处理己方随从
            foreach (Minion m in p.ownMinions.ToArray()) // 使用 ToArray() 避免修改集合时的迭代错误
            {
                if (m.Angr < attackThreshold)
                {
                    p.minionReturnToDeck(m, m.own);
                }
            }

            // 处理敌方随从
            foreach (Minion m in p.enemyMinions.ToArray()) // 使用 ToArray() 避免修改集合时的迭代错误
            {
                if (m.Angr < attackThreshold)
                {
                    p.minionReturnToDeck(m, m.own);
                }
            }
        }
    }
}
