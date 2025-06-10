using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_954t1 : SimTemplate //* 嘉沃顿 Galvadon
//<b>Battlecry:</b> <b>Adapt</b> 5 times.
//<b>战吼：</b>连续<b>进化</b>五次。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetBuffed(own, 6, 0);
            p.minionGetBuffed(own, 0, 3);
            own.taunt = true;
            own.divineshild = true;
        }
    }
}