using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_133 : SimTemplate //* 水晶商人 Crystal Merchant
//If you have any unspent Mana at the end of your turn, draw a card.
//在你的回合结束时，如果你有未使用的法力水晶，抽一张牌。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                if (p.mana >= 0)
				p.drawACard(CardDB.cardNameEN.unknown, turnEndOfOwner);
            }
        }
	}
}