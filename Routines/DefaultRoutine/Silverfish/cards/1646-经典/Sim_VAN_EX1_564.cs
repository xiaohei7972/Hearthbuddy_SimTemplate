using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_564 : SimTemplate //* 无面操纵者 Faceless Manipulator
	{
		//<b>Battlecry:</b> Choose a minion and become a copy of it.
		//<b>战吼：</b>选择一个随从，成为它的复制。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                //p.copyMinion(own, target);
                bool source = own.own;
                own.setMinionToMinion(target);
                own.own = source;
                own.handcard.card.sim_card.onAuraStarts(p, own);
            }
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}