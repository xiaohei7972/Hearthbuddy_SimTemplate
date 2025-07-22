using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_130 : SimTemplate //* 过度生长 Overgrowth
	{
		//Gain two empty Mana_Crystals.
		//获得两个空的法力水晶。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownMaxMana < 10)
                {
                    p.ownMaxMana+=2;
					if(p.ownMaxMana > 10 ) p.ownMaxMana = 10;
                }
                else
                {
                    p.drawACard(CardDB.cardNameEN.excessmana, true, true);
                }

            }
            else
            {
                if (p.enemyMaxMana < 10)
                {
                    p.enemyMaxMana+=2;
					if(p.enemyMaxMana > 10 ) p.enemyMaxMana = 10;
                }
                else
                {
                    p.drawACard(CardDB.cardNameEN.excessmana, false, true);
                }
            }
		}
		
	}
}
