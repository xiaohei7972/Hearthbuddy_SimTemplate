using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active47 : SimTemplate //* 布巴 Bubba
	{
		//<b>Battlecry</b>: Summon six 1/1 Bloodhounds to attack an enemy minion.
		//<b>战吼：</b>召唤六只1/1的血猎犬，攻击一个敌方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
