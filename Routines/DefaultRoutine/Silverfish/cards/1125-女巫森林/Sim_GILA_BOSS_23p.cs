using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_23p : SimTemplate //* 抛击 Chuck
	{
		//<b>Hero Power</b>Destroy a friendly minion and deal its Attack to the enemy hero.
		//<b>英雄技能</b>消灭一个友方随从。对敌方英雄造成相当于其攻击力的伤害。
		
		

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
