using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_BOSS_30p : SimTemplate //* 灼痛鞭笞 Searing Lash
	{
		//<b>Hero Power</b>Deal 1 damage to a friendly minion and give it +5 Attack.
		//<b>英雄技能</b>对一个友方随从造成1点伤害，并使其获得+5攻击力。
		
		

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
