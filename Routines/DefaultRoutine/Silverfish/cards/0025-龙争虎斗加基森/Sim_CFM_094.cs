using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_094 : SimTemplate //* 邪火药水 Felfire Potion
//Deal $5 damage to all characters.
//对所有角色造成$5点伤害。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.allCharsGetDamage(dmg);
        }
    }
}