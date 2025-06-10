using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FB_Toki_AttackPlayers : SimTemplate //* 时间线冲突 Timeline Collision
//Deal Attack damage to each Hero.
//对双方英雄造成等同于攻击力的伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
