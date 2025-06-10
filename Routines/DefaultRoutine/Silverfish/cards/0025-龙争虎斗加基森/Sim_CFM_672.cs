using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_672 : SimTemplate //* 郭雅夫人 Madam Goya
//<b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
//<b>战吼：</b>选择一个友方随从，与你牌库中的一个随从交换。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetFrozen(target);
                p.drawACard(CardDB.cardNameEN.aberration, m.own, true);
            }
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