using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_081 : SimTemplate //* 锐鳞骑士 Scalerider
	{
		//<b>Battlecry:</b> If you're holding a Dragon, deal 2 damage.
		//<b>战吼：</b>如果你的手牌中有龙牌，则造成2点伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
