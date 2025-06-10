using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_107 : SimTemplate //* 冰川急冻 glaciate
	{
        //<b>发现</b>一张法力值消耗为（8）的随从牌。召唤并<b>冻结</b>该随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal())
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_109), pos, ownplay, false);
            }
            else { p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_120), pos, ownplay, false);    
            }
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
