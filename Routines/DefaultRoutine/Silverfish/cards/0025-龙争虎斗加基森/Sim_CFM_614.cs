using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_614 : SimTemplate //* 玉莲印记 Mark of the Lotus
//Give your minions +1/+1.
//使你所有的随从获得+1/+1。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.allMinionOfASideGetBuffed(ownplay, 1, 1);
        }
    }
}