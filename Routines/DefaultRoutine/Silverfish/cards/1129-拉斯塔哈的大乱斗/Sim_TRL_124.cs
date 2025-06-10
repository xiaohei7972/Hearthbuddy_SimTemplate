using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_124 : SimTemplate //* 团伙劫掠 Raiding Party
//Draw 2 Pirates from_your deck.<b>Combo:</b> And a weapon.
//从你的牌库中抽两张海盗牌。<b>连击：</b>并抽一张武器牌。 
	{
        
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.southseacaptain, ownplay);
            p.drawACard(CardDB.cardNameEN.southseadeckhand, ownplay);

            if (p.cardsPlayedThisTurn > 0)
            {
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.drawACard(CardDB.cardNameEN.kingsbane, ownplay);
            }
        }
    }
}