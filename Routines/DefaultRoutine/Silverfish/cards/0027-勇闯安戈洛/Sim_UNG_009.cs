using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_009 : SimTemplate //* 暴掠龙幼崽 Ravasaur Runt
//<b>Battlecry:</b> If you control at_least 2 other minions, <b>Adapt.</b>
//<b>战吼：</b>如果你控制至少两个其他随从，便获得<b>进化</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int num = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (num > 1) p.getBestAdapt(own);
        }
    }
}