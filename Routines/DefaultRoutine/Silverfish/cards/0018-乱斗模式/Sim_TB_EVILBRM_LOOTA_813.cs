using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_EVILBRM_LOOTA_813 : SimTemplate //* 魔镜 Magic Mirror
//Choose a minion and summon a copy of it. Add it to your Dungeon_Deck.
//选择一个随从，召唤一个它的复制。将其加入你的地下城套牌。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
