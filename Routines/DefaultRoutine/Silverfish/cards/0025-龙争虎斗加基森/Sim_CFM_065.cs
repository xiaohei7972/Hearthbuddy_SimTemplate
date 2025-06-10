using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_065 : SimTemplate //* 火山药水 Volcanic Potion
//Deal $2 damage to all_minions.
//对所有随从造成$2点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionsGetDamage(dmg);
        }
    }
}