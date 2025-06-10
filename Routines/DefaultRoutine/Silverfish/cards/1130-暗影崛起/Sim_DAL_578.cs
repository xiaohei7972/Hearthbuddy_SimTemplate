using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_578 : SimTemplate //* 创世之力 Power of Creation
//<b>Discover</b> a 6-Cost minion. Summon two copies of it.
//<b>发现</b>一张法力值消耗为（6）的随从牌。召唤两个它的复制。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.icehowl), pos, ownplay, false);
            else
			{
				p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.frostgiant), pos, ownplay, false);
				p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.frostgiant), pos, ownplay, true);
			}
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}