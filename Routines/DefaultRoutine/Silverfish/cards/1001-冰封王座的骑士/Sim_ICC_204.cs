using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_204 : SimTemplate //* 普崔塞德教授 Professor Putricide
//After you play a <b>Secret</b>,put a random Hunter <b>Secret</b> into the battlefield.
//在你使用一个<b>奥秘</b>后，随机将一个猎人的<b>奥秘</b>置入战场。 
    {
        

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (hc.card.Secret) p.evaluatePenality -= 9;
        }

    }
}