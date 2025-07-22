using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_239 : SimTemplate //* 末日降临 DOOM!
//Destroy all minions. Draw a card for each.
//消灭所有随从。每消灭一个随从，便抽一张牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int anz = p.ownMinions.Count + p.enemyMinions.Count;
			p.allMinionsGetDestroyed();
            for (int i = 0; i < anz; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
		}
	}
}