using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t33 : SimTemplate //* 邪能花 Felbloom
//Deal $6 damage to all minions.
//对所有随从造成$6点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);
            p.allMinionsGetDamage(dmg);
        }
    }
}