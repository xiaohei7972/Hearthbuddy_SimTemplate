using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRLA_177 : SimTemplate //* 无羁惩罚者 Unbound Punisher
	{
		//<b>Battlecry:</b> Destroy allenemy minions.Gain 2 Armor for each minion destroyed.
		//<b>战吼：</b>消灭所有敌方随从。每消灭一个随从，获得2点护甲值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
            };
        }
	}
}
