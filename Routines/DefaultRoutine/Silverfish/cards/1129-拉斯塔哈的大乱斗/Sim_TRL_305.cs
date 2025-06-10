using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_305 : SimTemplate //* 新人登场 A New Challenger...
//<b>Discover</b> a 6-Cost minion. Summon it with <b>Taunt</b> and <b>Divine Shield</b>.
//<b>发现</b>一张法力值消耗为（6）的随从牌。召唤该随从并使其获得<b>嘲讽</b>和<b>圣盾</b>。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.icehowl), pos, ownplay, false);
            else p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.frostgiant), pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}