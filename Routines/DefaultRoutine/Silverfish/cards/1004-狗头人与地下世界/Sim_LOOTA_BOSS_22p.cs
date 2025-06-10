using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_22p : SimTemplate //* 放生 Catch and Release
	{
		//<b>Hero Power</b>Summon a random minion from your deck.
		//<b>英雄技能</b>从你的牌库中随机召唤一个随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
