using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_302 : SimTemplate //* 暂避锋芒 Time Out!
//Your hero is <b>Immune</b> until your next turn.
//直到你的下个回合，你的英雄获得<b>免疫</b>。 
	{
        
		
        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            target.immune = true;
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}

}