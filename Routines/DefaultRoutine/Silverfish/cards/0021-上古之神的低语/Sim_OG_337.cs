using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_337 : SimTemplate //* 巨型独眼怪 Cyclopian Horror
//<b>Taunt</b>. <b>Battlecry:</b> Gain      +1 Health for each enemy minion.
//<b>嘲讽，战吼：</b>每有一个敌方随从，便获得+1生命值。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int gain = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
			if (gain > 0) p.minionGetBuffed(own, 0, gain);
        }
    }
}