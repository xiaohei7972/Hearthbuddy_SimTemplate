using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_HunterPrince_03a : SimTemplate //* 恶魔冲击 Demonic Blast
//<b>Hero Power</b>Deal 5 damage.<i>(Two uses left!)</i>
//<b>英雄技能</b>造成5点伤害。<i>（还可使用两次！）</i> 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
