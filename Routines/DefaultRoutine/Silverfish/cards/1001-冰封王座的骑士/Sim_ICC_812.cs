using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_812: SimTemplate //* 绞肉车 Meat Wagon
//[x]<b>Deathrattle:</b> Summon aminion from your deckwith less Attack thanthis minion.
//<b>亡语：</b>从你的牌库中召唤一个攻击力小于该随从攻击力的随从。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            CardDB.cardIDEnum cId = CardDB.cardIDEnum.None;
            for (int i = m.Angr - 1; i >= 0; i--)
            {
                cId = p.prozis.getDeckCardsForCost(i);
                if (cId != CardDB.cardIDEnum.None) break;
            }
            if (cId != CardDB.cardIDEnum.None)
            {
                CardDB.Card kid = CardDB.Instance.getCardDataFromID(cId);
                p.callKid(kid, m.zonepos - 1, m.own);
            }
        }
    }
}