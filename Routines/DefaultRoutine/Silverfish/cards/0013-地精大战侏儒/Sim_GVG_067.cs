using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_067 : SimTemplate //* 碎石穴居人 Stonesplinter Trogg
//Whenever your opponent casts a spell, gain +1 Attack.
//每当你的对手施放一个法术，便获得+1攻击力。 
    {

        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard != triggerEffectMinion.own)
            {
                p.minionGetBuffed(triggerEffectMinion, 1, 0);
            }
        }


    }

}