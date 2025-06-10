using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_829p: SimTemplate //* 天启四骑士 The Four Horsemen
//[x]<b>Hero Power</b>Summon a 2/2 Horseman.If you have all 4, destroythe enemy hero.
//<b>英雄技能</b>召唤一个2/2的天启骑士。如果你控制所有四个天启骑士，消灭敌方英雄。 
    {
        

        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_829t2); 
        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_829t3); 
        CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_829t4); 
        CardDB.Card kid4 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_829t5); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid1, pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}