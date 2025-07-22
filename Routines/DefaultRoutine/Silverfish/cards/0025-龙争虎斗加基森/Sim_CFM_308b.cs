using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_308b : SimTemplate //* 遗忘法力 Forgotten Mana
//Refresh your Mana Crystals.
//复原你的法力水晶。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.mana = p.ownMaxMana;
            else p.mana = p.enemyMaxMana;
        }
    }
}