using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_913 : SimTemplate //* 托维尔守卫 Tol'vir Warden
//<b>Battlecry:</b> Draw two 1-Cost minions from your deck.
//<b>战吼：</b>从你的牌库中抽两张法力值消耗为（1）的随从牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                        p.drawACard(CardDB.cardNameEN.lepergnome, own.own);
                        p.drawACard(CardDB.cardNameEN.lepergnome, own.own);
            }
            else p.enemyAnzCards++;
		}
	}
}