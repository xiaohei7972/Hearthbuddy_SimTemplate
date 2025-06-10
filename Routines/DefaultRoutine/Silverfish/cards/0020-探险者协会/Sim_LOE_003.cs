using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_003 : SimTemplate //* 虚灵巫师 Ethereal Conjurer
//<b>Battlecry: Discover</b> a spell.
//<b>战吼：发现</b>一张法术牌。 
	{
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, own.own, true);
		}
		
	}
}