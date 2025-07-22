using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_016 : SimTemplate //* 邪恶的厨师 Crooked Cook
//在你的回合结束时，如果你已对敌方英雄造成3点或更多伤害，抽一张牌。
//At the end of your turn, if you dealt 3 or more damage to the enemy hero, draw a card.
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, turnEndOfOwner);
            }
        }
    }
}
