using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_116t : SimTemplate //* “践踏者”班纳布斯 Barnabus the Stomper
//<b>Battlecry:</b> Reduce theCost of minions in your deck to (0).
//<b>战吼：</b>使你牌库中所有随从的法力值消耗变为（0）点。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ownMinionsInDeckCost0 = true;
        }
    }
}