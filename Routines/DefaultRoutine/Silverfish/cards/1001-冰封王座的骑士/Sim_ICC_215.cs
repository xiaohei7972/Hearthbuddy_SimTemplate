using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_215: SimTemplate //* 大主教本尼迪塔斯 Archbishop Benedictus
//<b>Battlecry:</b> Shuffle a copy of_your opponent's deck into your deck.
//<b>战吼：</b>复制你对手的牌库，并洗入你的牌库。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.ownDeckSize += p.enemyDeckSize;
                p.evaluatePenality -= 6;
            }
            else p.enemyDeckSize += p.ownDeckSize;
        }
    }
}