using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_HERO_02bp2 : SimTemplate //* 图腾崇拜 Totemic Slam
	{
		//<b>Hero Power</b>Summon a Totem of your choice.
		//<b>英雄技能</b>召唤一个你想要的图腾。



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}