using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_854 : SimTemplate //* 琥口脱险 Free From Amber
//<b>Discover</b> a minion that costs (8) or more. Summon it.
//<b>发现</b>一张法力值消耗大于或等于（8）点的随从牌，并召唤该随从。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_125), pos, ownplay, false);
            else p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_120), pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
            };
        }
    }
}