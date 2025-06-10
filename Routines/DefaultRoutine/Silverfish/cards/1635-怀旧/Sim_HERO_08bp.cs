using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_08bp : SimTemplate //* 火冲
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;
            int dmg = (ownplay) ? p.getHeroPowerDamage(1) : p.getEnemyHeroPowerDamage(1);
            p.minionGetDamageOrHeal(target, dmg);
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}