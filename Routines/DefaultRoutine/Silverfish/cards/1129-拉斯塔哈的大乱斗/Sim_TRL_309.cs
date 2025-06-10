using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_309 : SimTemplate //* 猛虎之灵 Spirit of the Tiger
//[x]<b>Stealth</b> for 1 turn.After you cast a spell,summon a Tiger with statsequal to its Cost.
//<b>潜行</b>一回合。在你施放一个法术后，召唤一只属性值等于其法力值消耗的老虎。 
	{
		
		
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own == wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                int pos = (wasOwnCard) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(p.getRandomCardForManaMinion(hc.manacost), pos, wasOwnCard);
            }
        }
	}
}