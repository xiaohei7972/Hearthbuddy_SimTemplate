using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_128 : SimTemplate //* 骷髅骑士 The Skeleton Knight
//<b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
//<b>亡语：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则将骷髅骑士移回你的手牌。 
	{
		
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.minionReturnToHand(m, m.own, 0); 
        }
	}
}