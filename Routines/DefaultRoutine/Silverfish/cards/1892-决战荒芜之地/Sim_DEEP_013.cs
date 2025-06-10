using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：4
	//Fel Fissure
	//邪能陷隙
	//Deal $2 damage to all minions. At the start of your next turn, deal $2 more damage to all minions.
	//对所有随从造成$2点伤害。在你的下个回合开始时，再对所有随从造成$2点伤害。
	class Sim_DEEP_013 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 立即对所有随从造成2点伤害
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(2));
            }

            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetDamageOrHeal(m, p.getSpellDamageDamage(2));
            }
        }
    }
}
