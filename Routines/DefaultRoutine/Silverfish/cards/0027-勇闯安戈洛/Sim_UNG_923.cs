using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_923 : SimTemplate //* 铜皮铁甲 Iron Hide
//Gain 5 Armor.
//获得5点护甲值。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 5);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 5);
            }
		}

	}
}