using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_065 : SimTemplate //* 展览馆守卫 Menagerie Warden
//<b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
//<b>战吼：</b>选择一个友方野兽，召唤一个它的复制。 
	{
		
		
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
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}