using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRGA_004 : SimTemplate //* 巨龙骑士布莱恩 Dragonrider Brann
	{
		//[x]<b>Battlecry:</b> Deal 8 damageto an enemy minion andthe minions next to it.
		//<b>战吼：</b>对一个敌方随从及其相邻的随从造成8点伤害。
		
		

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
