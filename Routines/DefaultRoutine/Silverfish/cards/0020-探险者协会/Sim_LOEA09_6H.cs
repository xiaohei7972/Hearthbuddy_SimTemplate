using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOEA09_6H : SimTemplate //* 滑鳞弓箭手 Slithering Archer
//<b>Battlecry:</b> Deal 2 damage to all enemy minions.
//<b>战吼：</b>对所有敌方随从造成2点伤害。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
