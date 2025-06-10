using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 猎人 费用：2
	//Jungle Gym
	//丛林乐园
	//[x]Deal 1 damage to arandom enemy. Repeatfor each friendly Beast.
	//随机对一个敌人造成1点伤害。每有一只友方野兽，重复一次。
	class Sim_TOY_359 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 统计己方场上野兽的数量
            int beastCount = 0;
            foreach (Minion m in p.ownMinions)
            {
                if (m.handcard.card.race == CardDB.Race.BEAST)
                {
                    beastCount++;
                }
            }

            // 每有一只野兽，随机对一个敌人造成1点伤害
            for (int i = 0; i <= beastCount; i++)
            {
                // 随机选择一个敌方目标（包括敌方随从和英雄）
                Minion randomEnemy = p.getEnemyCharTargetForRandomSingleDamage(1);

                // 对随机选中的敌方目标造成1点伤害
                p.minionGetDamageOrHeal(randomEnemy, 1);
            }
        }

    }
}
