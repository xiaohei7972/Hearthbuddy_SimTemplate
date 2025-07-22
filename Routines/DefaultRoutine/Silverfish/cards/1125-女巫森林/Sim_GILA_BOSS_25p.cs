using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_25p : SimTemplate //* 布置陷阱 Trap Preparation
	{
		//<b>Hero Power</b>Put a random <b>Secret</b> from your deck into the battlefield.
		//<b>英雄技能</b>随机将一个<b>奥秘</b>从你的牌库中置入战场。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET),
            };
        }
	}
}
