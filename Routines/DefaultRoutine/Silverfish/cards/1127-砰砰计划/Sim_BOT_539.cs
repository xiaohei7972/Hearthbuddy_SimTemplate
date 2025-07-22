using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_539 : SimTemplate //* 奥能水母 Arcane Dynamo
//<b>Battlecry:</b> <b>Discover</b> a spell that costs (5) or more.
//<b>战吼：</b><b>发现</b>一张法力值消耗大于或等于（5）点的法术牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}
	}
}