using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_07_EarthenMight : SimTemplate //* 大地之力 Earthen Might
	{
		//[x]Give a minion +2/+2.If it's an Elemental, adda random Elementalto your hand.
		//使一个随从获得+2/+2。如果该随从是元素，则随机将一张元素牌置入你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
