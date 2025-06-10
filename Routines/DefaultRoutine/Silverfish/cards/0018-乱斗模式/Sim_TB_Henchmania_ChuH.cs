using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_Henchmania_ChuH : SimTemplate //* 暗中爆破 Undermine
//<b>Hero Power</b>Shuffle an Explosive into your opponent's deck.
//<b>英雄技能</b>将一张“炸药” 牌洗入你对手的牌库。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
