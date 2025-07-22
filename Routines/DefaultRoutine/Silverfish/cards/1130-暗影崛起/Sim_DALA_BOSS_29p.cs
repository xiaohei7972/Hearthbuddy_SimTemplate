using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DALA_BOSS_29p : SimTemplate //* 采矿 Excavate
	{
		//<b>Hero Power</b>Deal 2 damage to a friendly Elemental. Find out what's inside.
		//<b>英雄技能</b>对一个友方元素造成2点伤害，找到其中的矿藏。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 18),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
