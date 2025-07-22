using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_40p : SimTemplate //* 黯淡之光 Fading Light
	{
		//<b>Hero Power</b>Give a minion -1_Attack.
		//<b>英雄技能</b>使一个随从获得-1攻击力。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MIN_ATTACK, 1),
            };
        }
	}
}
