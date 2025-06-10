using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_925 : SimTemplate //* 暴躁的恐角龙 Ornery Direhorn
//<b>Taunt</b><b>Battlecry:</b> <b>Adapt</b>.
//<b>嘲讽，战吼：</b><b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.anzOwnElementalsLastTurn > 0 && own.own) p.getBestAdapt(own);
        }
    }
}