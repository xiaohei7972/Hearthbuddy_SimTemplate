using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRM_014 : SimTemplate //* 熔火怒犬 Core Rager
//<b>Battlecry:</b> If your hand is empty, gain +3/+3.
//<b>战吼：</b>如果你没有其他手牌，则获得+3/+3。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int cardsCount = (m.own) ? p.owncards.Count : p.enemyAnzCards;
            if (cardsCount <= 0)
            {
                p.minionGetBuffed(m, 3, 3);
            }
        }
    }
}