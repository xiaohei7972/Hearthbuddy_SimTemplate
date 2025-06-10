using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_108 : SimTemplate //* 重甲战马 Armored Warhorse
//<b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
//<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得<b>冲锋</b>。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetCharge(own); 
		}
	}
}