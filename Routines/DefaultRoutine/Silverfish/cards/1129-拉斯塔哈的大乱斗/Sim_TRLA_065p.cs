using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRLA_065p : SimTemplate //* 稳固投掷 Steady Throw
	{
		//<b>Hero Power</b>Deal $2 damage to the enemy hero.@<b>Hero Power</b>Deal $2 damage.
		//<b>英雄技能</b>对敌方英雄造成$2点伤害。@<b>英雄技能</b>造成$2点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_STEADY_SHOT),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
            };
        }
	}
}
