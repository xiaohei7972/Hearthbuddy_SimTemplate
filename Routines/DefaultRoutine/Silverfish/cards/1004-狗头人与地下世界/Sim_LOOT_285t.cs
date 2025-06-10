using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_285t : SimTemplate //* 塔盾+10 Tower Shield +10
//Gain 5 Armor.Gain 10 more Armor.
//获得5点护甲值，再获得10点护甲值。 
	
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 15);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 15);
            }
		}

	}
}