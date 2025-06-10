using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_019t : SimTemplate //* 黄金猿藏宝图 Map to the Golden Monkey
//Shuffle the Golden Monkey into your deck. Draw a card.
//将“黄金猿”洗入你的牌库。抽一张牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
			{
				p.ownDeckSize++;
			}
            else p.enemyDeckSize++;
			
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
	}
}