using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_31p : SimTemplate //* 偷来的古董 Pillaged Relics
	{
		//[x]<b>Hero Power</b>Choose a minion.Give it +1/+1, <b>Divine Shield</b>or <b> Taunt</b> at random.
		//<b>英雄技能</b>选择一个随从。随机使其获得+1/+1，<b>圣盾</b>或<b>嘲讽</b>中的一种。
		
		

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
