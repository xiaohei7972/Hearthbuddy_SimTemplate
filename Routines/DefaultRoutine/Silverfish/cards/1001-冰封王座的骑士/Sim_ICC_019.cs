using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_019: SimTemplate //* 骷髅法师 Skelemancer
//<b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
//<b>亡语：</b>如果此时是你对手的回合，则召唤一个8/8的骷髅。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_019t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (!p.isOwnTurn) p.callKid(kid, m.zonepos, m.own);
        }
    }
}