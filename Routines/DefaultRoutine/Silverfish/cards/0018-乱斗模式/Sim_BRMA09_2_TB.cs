using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA09_2_TB : SimTemplate //* 打开大门 Open the Gates
	{
		//<b>Hero Power</b>Summon three 1/1 Whelps.
		//<b>英雄技能</b>召唤三条1/1的雏龙。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRMA09_2t);
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
            p.callKid(kid, place, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
