using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t3 : SimTemplate //* 石鳞鱼油 Stonescale Oil
//Gain 4 Armor.
//获得4点护甲值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 4);
        }
    }
}