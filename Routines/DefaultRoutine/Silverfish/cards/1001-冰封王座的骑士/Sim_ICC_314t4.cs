using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t4 : SimTemplate //* 死亡之握 Death Grip
//Steal a minion from your opponent's deck and add it to your hand.
//从你对手的牌库中偷取一张随从牌，并置入你的手牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                if (p.enemyDeckSize > 0)
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
                    p.enemyDeckSize--;
                }
            }
            else
            {
                if (p.ownDeckSize > 0)
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
                    p.ownDeckSize--;
                }
            }
        }
    }
}