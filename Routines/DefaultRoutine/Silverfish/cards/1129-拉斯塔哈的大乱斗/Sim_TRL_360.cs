using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_360 : SimTemplate //* 领主之鞭 Overlord's Whip
//After you play a minion, deal 1 damage to it.
//在你使用一张随从牌后，对被召唤的随从造成1点伤害。 
    {

        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_360);

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (summonedMinion.playedFromHand && summonedMinion.own == m.own && summonedMinion.entitiyID != m.entitiyID)
            {
                p.minionGetDamageOrHeal(summonedMinion, 1);
            }
        }
    }
}