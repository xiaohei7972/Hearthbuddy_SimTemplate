using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_001 : SimTemplate //* 翼手龙宝宝 Pterrordax Hatchling
//<b><b>Battlecry:</b> Adapt</b>.
//<b>战吼：</b><b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.getBestAdapt(own);
        }
    }
}