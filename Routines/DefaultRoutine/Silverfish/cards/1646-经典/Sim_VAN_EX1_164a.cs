using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_164a : SimTemplate //* 快速生长 Rampant Growth
	{
		//Gain 2 Mana Crystals.
		//获得两个法力水晶。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
				p.mana = Math.Min(10, p.mana+2);
				p.ownMaxMana = Math.Min(10, p.ownMaxMana+2);
            }
            else
            {
				p.mana = Math.Min(10, p.mana+2);
				p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+2);
            }
        }

    }

}