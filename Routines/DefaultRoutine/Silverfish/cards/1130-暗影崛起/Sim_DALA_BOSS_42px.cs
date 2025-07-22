using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_42px : SimTemplate //* 弹跳洗牌 Pogoshuffle
	{
		//<b>Hero Power</b>Choose a minion. Shuffle 3 copies of it into your deck. Draw a card.
		//<b>英雄技能</b>选择一个随从。将该随从的三张复制洗入你的牌库。抽一张牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
