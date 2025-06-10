using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113p : SimTemplate //* 召唤宠物 summonpet
	{
        //<b>英雄技能</b> 召唤一个动物伙伴。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_NEW1_032);//米莎

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }

    }
}
