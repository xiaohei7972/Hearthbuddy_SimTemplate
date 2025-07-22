using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_832 : SimTemplate //* 血色绽放 Bloodbloom
//The next spell you cast this turn costs Health instead of Mana.
//在本回合中，你施放的下一个法术不再消耗法力值，转而消耗生命值。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.nextSpellThisTurnCostHealth = true;
        }
    }
}