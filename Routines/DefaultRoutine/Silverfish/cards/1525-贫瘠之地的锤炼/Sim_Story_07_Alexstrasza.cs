using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_07_Alexstrasza : SimTemplate //* 阿莱克丝塔萨 Alexstrasza
	{
		//Revive your hero 2 times.<b>Deathrattle:</b> Go <b>Dormant</b> for 2 turns.
		//你的英雄可以复活两次。<b>亡语：</b><b>休眠</b>两回合。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_HERO_TARGET),
            };
        }
	}
}
