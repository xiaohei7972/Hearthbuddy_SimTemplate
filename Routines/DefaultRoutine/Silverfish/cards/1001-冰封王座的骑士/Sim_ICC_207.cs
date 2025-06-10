using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_207: SimTemplate //* 吞噬意志 Devour Mind
//Copy 3 cards in your opponent's deck and add them to your hand.
//复制你对手的牌库中的三张牌，并将其置入你的手牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}