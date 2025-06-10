using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_01_FeralSpirit : SimTemplate //* 野性狼魂 Feral Spirit
	{
		//Summon two 2/3 Spirit Wolves with <b>Taunt</b>.
		//召唤两只2/3并具有<b>嘲讽</b>的幽灵狼。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
