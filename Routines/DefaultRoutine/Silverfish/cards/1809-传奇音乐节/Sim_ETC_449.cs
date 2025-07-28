using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 潜行者 费用：1
	//Fan Club
	//粉丝俱乐部
	//Restore #3 Health to all friendly characters.
	//为所有友方角色恢复#3点生命值。
	class Sim_ETC_449 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                int healAmount = 3; // 恢复的生命值数量

                // 为所有己方随从恢复生命值
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, -healAmount); // 恢复生命值用负数表示
                }

                // 为己方英雄恢复生命值
                p.minionGetDamageOrHeal(p.ownHero, -healAmount);
            }
        }
    }
}
