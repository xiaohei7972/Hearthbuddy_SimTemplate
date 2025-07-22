using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t17 : SimTemplate //* 石鳞鱼油 Stonescale Oil
//Gain 7 Armor.
//获得7点护甲值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 7);
        }
    }
}