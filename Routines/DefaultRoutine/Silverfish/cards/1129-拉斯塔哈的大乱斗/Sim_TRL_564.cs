using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_564 : SimTemplate //* 魔精大师兹伊希 Mojomaster Zihi
//<b>Battlecry:</b> Set each player to 5 Mana Crystals.
//<b>战吼：</b>将双方玩家的法力水晶重置为五个。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.ownMaxMana = 5;
				p.enemyMaxMana = 5;
            }
            else
            {
                p.ownMaxMana = 5;
				p.enemyMaxMana = 5;
            }
		}


	}
}