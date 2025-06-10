using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_616 : SimTemplate //* 夜行虎 Twilight Runner
	{
		//<b>Stealth</b>Whenever this attacks, draw 2 cards.
		//<b>潜行</b>每当该随从攻击，抽两张牌。
		public override void onAuraStarts(Playfield p, Minion own)
		{
			if (own.own)
            {
                own.ownBlessingOfWisdom+=2;
            }
            else
            {
                own.enemyBlessingOfWisdom+=2;
            }	
		}
		
	}
}
