using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active44 : SimTemplate //* 融合 Amalgamate
	{
		//[x]Destroy all friendly minions. Summon an Amalgamation with their combinedAttack and Health.
		//消灭所有友方随从。召唤一个融合怪，其攻击力与生命值是所有消灭随从的总和。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 1),
            };
        }
	}
}
