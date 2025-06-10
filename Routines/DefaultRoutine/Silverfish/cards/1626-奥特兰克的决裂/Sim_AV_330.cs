using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_330 : SimTemplate //* 纳鲁的赐福 giftofthenaaru
	{
		//为所有角色恢复#3点生命值。如果有角色仍处于受伤状态，抽一张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(3) : p.getEnemySpellHeal(3);
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetDamageOrHeal(m, -heal);
                if (m.Hp < m.maxHp)
                {
                    p.drawACard(CardDB.cardIDEnum.None, true);
                }
            }

            p.minionGetDamageOrHeal(p.ownHero, -heal);
            if (p.ownHero.Hp < p.ownHero.maxHp)
            {
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
        }
		
	}
}
