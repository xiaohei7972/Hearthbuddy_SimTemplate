using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_285 : SimTemplate //* 邪恶入骨 fullblownevil
	{
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates)
            {
                int times = (m.own) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
                p.allCharsOfASideGetRandomDamage(!m.own, times);
            }
        }
	}
}
