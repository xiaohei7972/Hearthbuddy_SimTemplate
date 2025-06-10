using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_133 : SimTemplate //* 加基森枪骑士 Gadgetzan Jouster
//<b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
//<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得+1/+1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 1, 1); 
		}
	}
}