using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_150 : SimTemplate //* 缚雾熊怪 Furbolg Mossbinder
	{
		//<b>Battlecry:</b> Transform a friendly minion into a 6/6_Elemental.
		//<b>战吼：</b>将一个友方随从变形成为一个6/6的元素。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}
