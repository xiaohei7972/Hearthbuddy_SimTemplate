using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_257: SimTemplate //* 唤尸者 Corpse Raiser
//[x]<b>Battlecry:</b> Give a friendlyminion "<b>Deathrattle:</b>  Resummon this minion."
//<b>战吼：</b>使一个友方随从获得“<b>亡语：</b>再次召唤该随从。” 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) target.ancestralspirit++;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}