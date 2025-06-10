using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_963 : SimTemplate //* “太阳裂片”莱拉 Lyra the Sunshard
//Whenever you cast a spell, add a random Priest spell to your hand.
//每当你施放一个法术，随机将一张牧师法术牌置入你的手牌。 
	{
		

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, wasOwnCard);
            }
        }
	}
}