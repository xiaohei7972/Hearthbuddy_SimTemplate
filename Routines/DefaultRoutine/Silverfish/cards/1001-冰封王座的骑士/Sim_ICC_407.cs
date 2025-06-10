using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_407: SimTemplate //* 侏儒吸血鬼 Gnomeferatu
//<b>Battlecry:</b> Removethe top card of your opponent's deck.
//<b>战吼：</b>移除你对手的牌库顶的一张牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.enemyDeckSize = Math.Max(0, p.enemyDeckSize - 1);
            else p.ownDeckSize = Math.Max(0, p.ownDeckSize - 1);
        }
    }
}