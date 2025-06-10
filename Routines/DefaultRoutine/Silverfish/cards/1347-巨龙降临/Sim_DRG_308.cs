using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_308 : SimTemplate //* 夺心者卡什 Mindflayer Kaahrj
	{
		//<b>Battlecry:</b> Choose anenemy minion.<b>Deathrattle:</b> Summon a new copy of it.
		//<b>战吼：</b>选择一个敌方随从。<b>亡语：</b>召唤一个所选随从的全新复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
