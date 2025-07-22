using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_Hunter_HP2 : SimTemplate //* 宠物训练 Pet Training
	{
		//<b>Hero Power</b>Add a 1/1 Shifting Chameleon to your hand.
		//<b>英雄技能</b>将一张1/1的变色龙置入你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
	}
}
