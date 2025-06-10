using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_732 : SimTemplate //* 守护者斯塔拉蒂斯 Keeper Stalladris
//After you cast a <b>Choose One</b> spell, add copies of both choices_to_your_hand.
//在你施放了一个<b>抉择</b>法术后，将每个选项的复制置入你的手牌。 
	{
		
		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (wasOwnCard == triggerEffectMinion.own && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.drawACard(CardDB.cardNameEN.unknown, wasOwnCard, true);
            }
        }
    }
}