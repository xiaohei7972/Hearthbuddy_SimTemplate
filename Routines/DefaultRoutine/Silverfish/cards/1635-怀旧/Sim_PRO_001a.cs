using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_PRO_001a : SimTemplate //* 我是鱼人 I Am Murloc
//Summon three, four, or five 1/1 Murlocs.
//召唤三个、四个或者五个1/1的鱼人。
    {
        
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.PRO_001at);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int posi = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count ;

            p.callKid(kid, posi, ownplay, false);
            p.callKid(kid, posi, ownplay);
            p.callKid(kid, posi, ownplay);
            p.callKid(kid, posi, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}
