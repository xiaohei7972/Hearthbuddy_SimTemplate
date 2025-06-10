using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_068 : SimTemplate //* 石腭穴居人壮汉 Burly Rockjaw Trogg
//Whenever your opponent casts a spell, gain +2 Attack.
//每当你的对手施放一个法术，获得+2攻击力。 
    {

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard != triggerEffectMinion.own)
            {
                p.minionGetBuffed(triggerEffectMinion, 2, 0);
            }
        }


    }

}