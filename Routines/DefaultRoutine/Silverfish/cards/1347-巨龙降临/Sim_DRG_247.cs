using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_247 : SimTemplate //* 封印命运 Seal Fate
	{
		//Deal $3 damage to an undamaged character. <b>Invoke</b> Galakrond.
		//对一个未受伤的角色造成$3点伤害。<b>祈求</b>迦拉克隆。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_UNDAMAGED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
