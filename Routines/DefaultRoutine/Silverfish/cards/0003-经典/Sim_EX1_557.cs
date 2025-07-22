using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_557 : SimTemplate //* 纳特·帕格 Nat Pagle
	{
        //At the start of your turn, you have a 50% chance to draw an extra card.
        //在你的回合开始时，你有50%的几率额外抽一张牌。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, turnEndOfOwner);
            }
        }

    }
}