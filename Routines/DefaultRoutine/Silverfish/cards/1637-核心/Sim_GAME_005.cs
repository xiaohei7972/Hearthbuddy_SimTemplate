using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GAME_005 : SimTemplate //* 幸运币 The Coin
	{
		//Gain 1 Mana Crystal this turn only.
		//在本回合中，获得一个法力水晶。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.mana++;
            }
            else
            {
                p.mana++;
            }
        }

	}
}