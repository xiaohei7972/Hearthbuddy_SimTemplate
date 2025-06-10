using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_44p : SimTemplate //* 空心针 Hollow Needle
	{
		//<b>Hero Power</b>Deal $1 damage to a minion. If it dies, restore #3 Health to your hero.
		//<b>英雄技能</b>对一个随从造成$1点伤害。如果该随从死亡，为你的英雄恢复#3点生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
