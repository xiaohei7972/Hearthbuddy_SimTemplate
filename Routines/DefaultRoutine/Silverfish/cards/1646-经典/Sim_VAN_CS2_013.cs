using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_013 : SimTemplate //* 野性成长 Wild Growth
	{
		//Gain an empty Mana Crystal.
		//获得一个空的法力水晶。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownMaxMana < 10)
                {
                    p.ownMaxMana++;
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
                    p.enemyMaxMana++;
                }
                else
                {
                    p.drawACard(CardDB.cardNameEN.excessmana, false, true);
                }
            }
		}

	}
}