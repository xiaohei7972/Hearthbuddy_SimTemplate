using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：4
	//Fel Fissure
	//邪能陷隙
	//At the start of your next turn, deal $2 more damage to all minions.
	//在你的下个回合开始时，再对所有随从造成$2点伤害。
	class Sim_DEEP_013t : SimTemplate
	{
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            // 确保是在玩家的回合开始时触发
            if (turnStartOfOwner)
            {
                // 对所有己方随从造成2点伤害
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(2));
                }

                // 对所有敌方随从造成2点伤害
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(2));
                }
            }
        }
    }
}
