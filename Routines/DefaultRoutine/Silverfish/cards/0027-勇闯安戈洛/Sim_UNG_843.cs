using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_843 : SimTemplate //* 沃拉斯 The Voraxx
//[x]After you cast a spell onthis minion, summon a1/1 Plant and castanother copy on it.
//在你对该随从施放一个法术后，召唤一个1/1的植物，并对其施放相同的法术。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_999t2t1); 
        
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && hc.target != null && hc.target.entitiyID == triggerEffectMinion.entitiyID)
            {
                List<Minion> tmp = triggerEffectMinion.own ? p.ownMinions : p.enemyMinions;

                if (tmp.Count < 7)
                {
                    p.callKid(kid, triggerEffectMinion.zonepos, triggerEffectMinion.own);
                    hc.card.sim_card.onCardPlay(p, wasOwnCard, tmp[triggerEffectMinion.zonepos], hc.extraParam2);
                }
            }
        }
    }
}