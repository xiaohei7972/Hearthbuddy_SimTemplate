using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_047 : SimTemplate //* 墓穴蜘蛛 Tomb Spider
//<b>Battlecry: Discover</b> a Beast.
//<b>战吼：发现</b>一张野兽牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.rivercrocolisk, own.own, true);
		}
	}
}