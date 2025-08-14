using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Abstraction;

namespace HREngine.Bots

{//* 摇摆的俾格米 Wobbling Runts
 //<b>Deathrattle:</b> Summon three 2/2 Runts.
 //<b>亡语：</b>召唤三个2/2的俾格米。 
    class Sim_LOE_089 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t);
        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t2);
        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_089t3);


        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
            p.callKid(kid1, m.zonepos, m.own);
            p.callKid(kid2, m.zonepos + 1, m.own);
        }
    }
}