using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_308a : SimTemplate //* 遗忘护甲 Forgotten Armor
//Gain 10 Armor.
//获得10点护甲值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 10);
        }
    }
}