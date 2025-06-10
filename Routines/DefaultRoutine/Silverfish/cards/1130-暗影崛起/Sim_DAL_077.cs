using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_077 : SimTemplate //* 毒鳍鱼人
    {
        // 战吼：使一个友方鱼人获得剧毒。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            
            if ( target != null && own.own)
            {
                target.poisonous = true;
                if (own.own && target.name == CardDB.cardNameEN.firemancerflurgl)
                {
                    foreach (Minion m in p.enemyMinions)
                    {
                        p.evaluatePenality -= m.Hp * 2;
                        p.minionGetDestroyed(m);
                    }
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 14),
            };
        }
    }
}