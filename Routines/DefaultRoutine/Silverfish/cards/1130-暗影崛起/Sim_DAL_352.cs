using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_352 : SimTemplate //* 晶歌传送门 Crystalsong Portal
//<b>Discover</b> a Druid minion. If your hand has no minions, keep all 3.
//<b>发现</b>一张德鲁伊随从牌。如果你的手牌中没有随从牌，则保留全部三张牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			
			int cardsCount = (ownplay) ? p.owncards.Count : p.enemyAnzCards;
            if (cardsCount <= 0) 
			{	            
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);	
			}  
		}
	}
}