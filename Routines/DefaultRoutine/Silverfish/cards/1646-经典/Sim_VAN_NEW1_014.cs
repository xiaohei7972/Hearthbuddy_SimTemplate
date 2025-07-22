using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_NEW1_014 : SimTemplate //* 伪装大师 Master of Disguise
	{
		//<b>Battlecry:</b> Give a friendly minion <b>Stealth</b> until your next turn.
		//<b>战吼：</b>直到你的下个回合，使一个友方随从获得<b>潜行</b>。

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
            {
                target.stealth = true;
                target.conceal = true;
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}