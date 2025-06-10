using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_236 : SimTemplate //Never Surrender
	{
		//
        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
		    if (p.ownMinions.Count < 3) p.evaluatePenality += 30;
			if (p.ownMinions.Count > 4)	p.evaluatePenality -= 50;				
        }
	}
}