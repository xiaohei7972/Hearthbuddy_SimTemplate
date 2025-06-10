using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Funhouse Mirror
	//哈哈镜
	//Summon a copyof an enemy minion.It attacks the original.
	//召唤一个敌方随从的一个复制并使其攻击本体。
	class Sim_MIS_714 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 召唤一个敌方随从的复制
                int position = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(target.handcard.card, position, ownplay);

                // 获取最后一个召唤的随从
                Minion copy;
                if (ownplay)
                {
                    copy = p.ownMinions[p.ownMinions.Count - 1];
                }
                else
                {
                    copy = p.enemyMinions[p.enemyMinions.Count - 1];
                }

                // 复制攻击原随从
                if (copy != null)
                {
                    p.minionAttacksMinion(copy, target);
                }
            }
        }
    }
}
