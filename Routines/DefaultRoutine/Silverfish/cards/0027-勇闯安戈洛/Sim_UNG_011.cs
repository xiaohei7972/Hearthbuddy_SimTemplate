using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_011 : SimTemplate //* Hydrologist
	{
		//Battlecry: Discover a Secret.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.CORE_FP1_020,true, true);
        }
    }
}