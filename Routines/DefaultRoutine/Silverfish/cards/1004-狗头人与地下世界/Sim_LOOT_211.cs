using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_211 : SimTemplate //* 精灵咏唱者 Elven Minstrel
	{
		//<b>Combo:</b> Draw 2 minions from your deck.
		//<b>连击：</b>从你的牌库中抽两张随从牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
