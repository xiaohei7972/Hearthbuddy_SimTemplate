using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_290 : SimTemplate //* 上古之神先驱 Ancient Harbinger
//At the start of your turn, put a 10-Cost minion from your deck into your hand.
//在你的回合开始时，将一个法力值消耗为（10）的随从从你的牌库置入你的手牌。 
	{
		
		
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
				p.drawACard(CardDB.cardNameEN.varianwrynn, turnStartOfOwner);
            }
        }
	}
}