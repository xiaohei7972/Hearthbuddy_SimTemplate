using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_51p : SimTemplate //* 诱惑旋律 Alluring Tune
	{
		//<b>Hero Power</b>Gain control of an enemy_minion with 2 or less Attack.
		//<b>英雄技能</b>获得一个攻击力小于或等于2的敌方随从的控制权。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 2),
            };
        }
	}
}
