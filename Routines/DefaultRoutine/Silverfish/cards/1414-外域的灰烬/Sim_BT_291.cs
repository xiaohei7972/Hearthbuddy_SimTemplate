using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_291 : SimTemplate //* 埃匹希斯冲击 Apexis Blast
	{
		//Deal $5 damage.If your deck has no minions, summon a random 5-Cost minion.
		//造成$5点伤害。如果你的牌库中没有随从牌，随机召唤一个法力值消耗为（5）的随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
