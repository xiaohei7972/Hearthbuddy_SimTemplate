using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_52p : SimTemplate //* 抹上煤灰 Soot Up
	{
		//<b>Hero Power</b>Give a friendly minion <b>Stealth</b> until your next turn.
		//<b>英雄技能</b>直到你的下个回合，使一个友方随从获得<b>潜行</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
