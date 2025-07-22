using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRGA_BOSS_05t5 : SimTemplate //* 清理机器人 Recyclebot
	{
		//[x]<b>Battlecry:</b> Destroy a friendlyMech to add three<b>Spare Parts</b> to your hand.
		//<b>战吼：</b>消灭一个友方机械，将三张<b>零件</b>牌置入你的手牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 17),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
