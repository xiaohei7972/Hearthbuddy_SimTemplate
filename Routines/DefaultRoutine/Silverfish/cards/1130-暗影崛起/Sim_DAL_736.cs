using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_736 : SimTemplate //* 档案员艾丽西娜 Archivist Elysiana
//<b>Battlecry:</b> <b>Discover</b> 5 cards. Replace your deck with 2_copies of each.
//<b>战吼：</b><b>发现</b>五张卡牌，将你牌库里的所有卡牌替换成每张卡牌的两张复制。 
	{
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.ownDeckSize += 10;
			}
		}	
	}
}