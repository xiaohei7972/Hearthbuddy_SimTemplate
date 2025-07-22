using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Mixtape
	//串烧磁带
	//<b>Discover</b> a copy of a card your opponent played this game.
	//<b>发现</b>一张你的对手在本局对战中使用过的牌的复制。
	class Sim_ETC_074 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true); 
		}
		
	}
}
