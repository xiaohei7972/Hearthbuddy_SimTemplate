using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_56p : SimTemplate //* 新的面具 A New Face
	{
		//<b>Hero Power</b>Transform a minion into a random one that costs (2) more.
		//<b>英雄技能</b>将一个随从随机变形成为法力值消耗增加（2）点的随从。
		
		

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
