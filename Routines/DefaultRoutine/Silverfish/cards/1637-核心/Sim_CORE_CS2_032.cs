using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_CS2_032 : SimTemplate //flamestrike
	{

//    fÃ¼gt allen feindlichen dienern $4 schaden zu.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
		}

	}
}