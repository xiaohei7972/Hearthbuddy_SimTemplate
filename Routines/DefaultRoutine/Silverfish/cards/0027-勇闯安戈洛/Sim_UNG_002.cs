using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_002 : SimTemplate //* 火山龙 Volcanosaur
//<b>Battlecry:</b> <b>Adapt</b>, then_<b>Adapt</b>.
//<b>战吼：</b>连续<b>进化</b>两次。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.getBestAdapt(own);
			p.getBestAdapt(own);
        }
    }
}