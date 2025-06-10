using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Malfunction
	//玩具故障
	//Deal $3 damage split among all enemy minions. If your deck has no minions, deal $3 more.
	//造成$3点伤害，随机分配到所有敌方随从身上。如果你的牌库中没有随从牌，再造成$3点。
	class Sim_MIS_107 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 造成3点伤害，随机分配到所有敌方随从身上
            int baseDamage = 3;
            int totalDamage = baseDamage;

            // 检查牌库中是否有随从牌
            if (!p.hasMinionsInDeck())
            {
                // 如果牌库中没有随从牌，再造成3点伤害
                totalDamage += 3;
            }

            // 伤害分配给所有敌方随从
            for (int i = 0; i < totalDamage; i++)
            {
                Minion m = p.getEnemyCharTargetForRandomSingleDamage(1, true); // true表示只考虑敌方随从
                if (m != null)
                {
                    p.minionGetDamageOrHeal(m, 1);
                }
            }
        }
    }
}
