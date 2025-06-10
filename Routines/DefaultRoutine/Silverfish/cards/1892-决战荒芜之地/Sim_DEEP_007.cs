using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：3 攻击力：2 生命值：3
	//Sir Finley, the Intrepid
	//无畏爵士芬利
	//[x]<b>Battlecry</b>: If you've <b>Excavated</b>twice, transform all enemyminions into 1/1 Murlocs.
	//<b>战吼：</b>如果你已经<b>发掘</b>过两次，将所有敌方随从变形成为1/1的鱼人。
	class Sim_DEEP_007 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            // 检查玩家是否已经发掘过两次
            if (p.allExcavationCount >= 2)
            {
                // 遍历所有敌方随从
                foreach (Minion enemyMinion in p.enemyMinions)
                {
                    // 将每个敌方随从变形为1/1的鱼人
                    p.minionTransform(enemyMinion, CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOEA10_3));
                }
            }
        }
    }
}
