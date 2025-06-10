using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_527 : SimTemplate //* 达卡莱幻术师 Drakkari Trickster
//[x]<b>Battlecry:</b> Give each player acopy of a random card fromtheir opponent's deck.
//<b>战吼：</b>使双方玩家各随机获得一张对方牌库中的卡牌的复制。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, true);
            p.drawACard(CardDB.cardNameEN.unknown, false);

		}


	}
}