using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_ShadowReflection_001 : SimTemplate //* 暗影映像 Shadow Reflection
//Each time you play a card, transform this into a copy of it until the end of your turn.
//每当你使用一张牌，变形成为该卡牌的复制，直到你的回合结束。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MUST_PLAY_OTHER_CARD_FIRST),
            };
        }
	}
}
