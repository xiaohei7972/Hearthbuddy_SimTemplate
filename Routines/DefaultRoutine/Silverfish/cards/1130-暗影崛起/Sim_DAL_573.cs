using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_573 : SimTemplate //* 指挥官蕾撒 Commander Rhyssa
//Your <b>Secrets</b> trigger twice.
//你的<b>奥秘</b>会触发两次。 
    {
        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (hc.card.Secret) p.evaluatePenality -= 20;
        }

    }
}