using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_131 : SimTemplate //* 沙地苦工 Sand Drudge
//Whenever you cast a spell, summon a 1/1 Zombie with <b>Taunt</b>.
//每当你施放一个法术，召唤一个1/1并具有<b>嘲讽</b>的僵尸。 
	{
		

        CardDB.Card d = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_131t);

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard == triggerEffectMinion.own)
            {
                p.callKid(d, triggerEffectMinion.zonepos, triggerEffectMinion.own);
            }

        }

	}
}