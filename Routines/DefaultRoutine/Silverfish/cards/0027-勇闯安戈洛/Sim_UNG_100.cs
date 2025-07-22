using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_100 : SimTemplate //* 苍绿长颈龙 Verdant Longneck
//<b>Battlecry:</b> <b>Adapt</b>.
//<b>战吼：</b><b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.getBestAdapt(own);
        }
    }
}