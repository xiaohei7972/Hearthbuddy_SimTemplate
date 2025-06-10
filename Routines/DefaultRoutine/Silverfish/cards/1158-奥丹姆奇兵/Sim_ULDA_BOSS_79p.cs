using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_79p : SimTemplate //* 机械“驾驶” Mech "Pilot"
	{
		//[x]<b>Hero Power</b>Give a Mech +2 Attack thisturn and force it to attack arandom enemy minion.
		//<b>英雄技能</b>在本回合中，使一个机械获得+2攻击力并迫使其随机攻击一个敌方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 17),
            };
        }
	}
}
