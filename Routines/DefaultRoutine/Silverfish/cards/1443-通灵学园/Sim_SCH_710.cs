using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_710 : SimTemplate //* 食人魔巫术师 Ogremancer
	{
		//[x]Whenever your opponentcasts a spell, summon a 2/2Skeleton with <b>Taunt</b>.
		//每当你的对手施放一个法术，召唤一个2/2并具有<b>嘲讽</b>的骷髅。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_710t);
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own != wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kid, pos, wasOwnCard);
            }
        }
		
	}
}
