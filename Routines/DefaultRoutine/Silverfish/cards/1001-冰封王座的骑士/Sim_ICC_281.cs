using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_281: SimTemplate //* 灵魂洪炉 Forge of Souls
//Draw 2 weapons from your deck.
//从你的牌库中抽两张武器牌。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                foreach (var cid in p.CheckTurnDeckForType(CardDB.cardtype.WEAPON, 2))
                {
                    p.drawACard(cid, ownplay);
                }
            }
        }
    }
}