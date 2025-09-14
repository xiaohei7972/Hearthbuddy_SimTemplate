using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 考内留斯·罗姆 Cornelius Roame
    //[x]At the start and end_of each player's turn,draw a card.
    //在每个玩家的回合开始和结束时，抽一张牌。
    class Sim_SW_080 : SimTemplate
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
        }

    }
}
