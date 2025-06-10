using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_066 : SimTemplate //* 王室图书管理员 Royal Librarian
	{
		//[x]<b>Tradeable</b><b>Battlecry:</b> <b>Silence</b>a minion.
		//<b>可交易</b><b>战吼：</b><b>沉默</b>一个随从。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetSilenced(target);
		}		
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
