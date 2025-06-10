using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_067: SimTemplate //* 维库食尸鬼 Vryghoul
//[x]<b>Deathrattle:</b> If it's youropponent's turn,summon a 2/2 Ghoul.
//<b>亡语：</b>如果此时是你对手的回合，则召唤一个2/2的食尸鬼。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_900t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (!p.isOwnTurn) p.callKid(kid, m.zonepos, m.own);
        }
    }
}