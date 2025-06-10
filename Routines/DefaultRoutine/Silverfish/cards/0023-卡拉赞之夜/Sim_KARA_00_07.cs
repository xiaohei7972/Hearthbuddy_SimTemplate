using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_00_07 : SimTemplate //* 星界传送门 Astral Portal
//Summon a random <b>Legendary</b> minion.
//随机召唤一个<b>传说</b>随从。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
