using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_920t1 : SimTemplate //* 卡纳莎女王 Queen Carnassa
//<b>Battlecry:</b> Shuffle 15 Raptors into your deck.
//<b>战吼：</b>将15张迅猛龙牌洗入你的牌库。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
			{
				p.ownDeckSize += 15;
				p.evaluatePenality -= 20;
			}
		}
	}
}