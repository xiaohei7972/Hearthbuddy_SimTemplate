using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_EVILBRM_BoomHeroPower : SimTemplate //* 埋设炸弹 Overmine
//[x]<b>Hero Power</b>Shuffle two Bombsinto your opponent'sdeck.
//<b>英雄技能</b>将两张“炸弹” 牌洗入你对手的牌库。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
