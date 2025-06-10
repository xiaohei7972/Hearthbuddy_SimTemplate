using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_021 : SimTemplate //* 邪恶的巫医 Wicked Witchdoctor
//Whenever you cast a spell, summon a random basic_Totem.
//每当你施放一个法术，随机召唤一个基础图腾。 
	{
		

        CardDB.Card searing = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050);
        CardDB.Card healing = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_009);
        CardDB.Card wrathofair = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_052);
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
				CardDB.Card kid;
				int otherTotems = 0;
				bool wrath = false;
                foreach (Minion m in (wasOwnCard) ? p.ownMinions : p.enemyMinions)
				{
					switch (m.name)
					{
						case CardDB.cardNameEN.searingtotem: otherTotems++; continue;
						case CardDB.cardNameEN.stoneclawtotem: otherTotems++; continue;
						case CardDB.cardNameEN.healingtotem: otherTotems++; continue;
						case CardDB.cardNameEN.wrathofairtotem: wrath = true; continue;
					}
				}
				if (p.isLethalCheck)
				{
					if (otherTotems == 3 && !wrath) kid = wrathofair;
					else kid = healing;
				}
				else
				{
					if (!wrath) kid = wrathofair;
					else kid = searing;
				}
                p.callKid(kid, triggerEffectMinion.zonepos, wasOwnCard);
            }
        }
	}
}