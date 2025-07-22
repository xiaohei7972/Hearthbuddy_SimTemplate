using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GILA_BOSS_59p : SimTemplate //* 弹幕 Pistol Barrage
	{
		//<b>Hero Power</b>Deal $2 damage to a minion and the minions next to it.
		//<b>英雄技能</b>对一个随从和其相邻的随从造成$2点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}
