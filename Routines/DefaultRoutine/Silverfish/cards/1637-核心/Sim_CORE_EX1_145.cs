using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_145 : SimTemplate //preparation
	{

//    der nÃ¤chste zauber, den ihr in diesem zug wirkt, kostet (3) weniger.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.playedPreparation = true;
            }
		}

	}
}