using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_720 : SimTemplate //* 血誓雇佣兵 Bloodsworn Mercenary
	{
        //[x]<b>Battlecry</b>: Choose adamaged friendly minion.Summon a copy of it.
        //<b>战吼：</b>选择一个受伤的友方随从，召唤一个它的复制。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null && own.own && p.ownMinions.Count < 7)
            {
                int pos = p.ownMinions.Count;
                p.callKid(own.handcard.card, pos, own.own);
                p.ownMinions[pos].setMinionToMinion(target);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_DAMAGED_TARGET),
            };
        }
    }
}