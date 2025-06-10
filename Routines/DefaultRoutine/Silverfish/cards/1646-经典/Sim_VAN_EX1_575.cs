using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_575 : SimTemplate //* 法力之潮图腾 Mana Tide Totem
	{
		//At the end of your turn, draw a card.
		//在你的回合结束时，抽一张牌。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, turnEndOfOwner);
            }
        }

	}
}