using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KARA_13_11 : SimTemplate //* 暗影箭雨 Shadow Bolt Volley
//Deal $4 damage to three random enemies.
//随机对三个敌人造成$4点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 2),
            };
        }
	}
}
