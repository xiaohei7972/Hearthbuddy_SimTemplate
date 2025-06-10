using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t6 : SimTemplate //* 湮灭 Obliterate
//Destroy a minion. Your hero takes damage equal to its Health.
//消灭一个随从。你的英雄受到等同于该随从生命值的伤害。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, target.Hp);
            p.minionGetDestroyed(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}