using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_314t2 : SimTemplate //* 罪罚（等级3） Condemn (Rank 3)
	{
		//Deal $3 damage to all enemy minions.
		//对所有敌方随从造成$3点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }		
		
	}
}
