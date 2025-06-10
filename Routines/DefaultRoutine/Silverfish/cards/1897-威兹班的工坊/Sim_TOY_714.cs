using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Fly Off the Shelves
	//飞速离架
	//Deal $1 damage to all enemy minions. Repeat for each Dragon you're holding.
	//对所有敌方随从造成$1点伤害。你手牌中每有一张龙牌，重复一次。
	class Sim_TOY_714 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dragonCount = 0;

            // 统计手牌中龙牌的数量
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
                {
                    dragonCount++;
                }
            }

            // 对所有敌方随从造成1点伤害，并根据龙牌的数量重复
            for (int i = 0; i <= dragonCount; i++)
            {
                foreach (Minion m in p.enemyMinions.ToArray())
                {
                    p.minionGetDamageOrHeal(m, 1);
                }
            }
        }

    }
}
