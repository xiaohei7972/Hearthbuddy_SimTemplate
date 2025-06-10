using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_308 : SimTemplate //* 遗忘之王库恩 Kun the Forgotten King
//<b>Choose One -</b> Gain 10 Armor; or Refresh your Mana Crystals.
//<b>抉择：</b>获得10点护甲值；或者复原你的法力水晶。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && m.own))
            {
                p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 10);
            }

            if (choice == 2 || (p.ownFandralStaghelm > 0 && m.own))
            {
                if (m.own) p.mana = p.ownMaxMana;
                else p.mana = p.enemyMaxMana;
            }
        }
    }
}