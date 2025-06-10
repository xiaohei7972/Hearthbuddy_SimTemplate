using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_373 : SimTemplate //* 治疗之雨 Healing Rain
//Restore #12 Health randomly split among all friendly characters.
//恢复#12点生命值，随机分配到所有友方角色上。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(12) : p.getEnemySpellDamageDamage(12);

            List<Minion> temp = new List<Minion>(p.ownMinions);
            temp.Add(p.ownHero);

            for (int i = 0; i < dmg; i++)
            {
                int surviving = 0;
                foreach (Minion m in temp.ToArray())
                {
                    if (m.Hp < 1) continue;
                    p.minionGetDamageOrHeal(m, -1);
                    i++;
                    surviving++;
                    if (i >= dmg) break;
                }
                if (surviving == 0) break;
            }
        }

	}
}