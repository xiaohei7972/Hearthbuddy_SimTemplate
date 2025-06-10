using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_022 : SimTemplate //* 幻象制造者 Mirage Caller
//<b>Battlecry:</b> Choose a friendly minion. Summon a 1/1 copy of it.
//<b>战吼：</b>选择一个友方随从，召唤一个它的1/1复制。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null && p.ownMinions.Count < 7)
            {
                p.callKid(own.handcard.card, own.zonepos, own.own);
                p.ownMinions[own.zonepos].setMinionToMinion(target);
                p.ownMinions[own.zonepos].Angr = 1;
                p.ownMinions[own.zonepos].Hp = 1;
                p.ownMinions[own.zonepos].maxHp = 1;
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