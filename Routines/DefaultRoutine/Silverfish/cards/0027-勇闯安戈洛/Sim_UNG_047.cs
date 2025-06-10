using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_047 : SimTemplate //* 饥饿的翼手龙 Ravenous Pterrordax
//<b>Battlecry:</b> Destroy a friendly minion to <b>Adapt</b>_twice.
//<b>战吼：</b>消灭一个友方随从，并连续<b>进化</b>两次。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (target != null)
			{
				p.minionGetDestroyed(target);
				p.getBestAdapt(own);
				p.getBestAdapt(own);
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}