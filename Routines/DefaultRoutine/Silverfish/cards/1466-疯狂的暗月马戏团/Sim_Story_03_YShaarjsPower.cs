using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_03_YShaarjsPower : SimTemplate //* 亚煞极之力 Y'Shaarj's Power
	{
		//[x]<b>Quest:</b> Kill8 enemy minions.<b>Reward:</b> Corruption.
		//<b>任务：</b>消灭八个敌方随从。<b>奖励：</b>堕入腐蚀。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2),
            };
        }
	}
}
