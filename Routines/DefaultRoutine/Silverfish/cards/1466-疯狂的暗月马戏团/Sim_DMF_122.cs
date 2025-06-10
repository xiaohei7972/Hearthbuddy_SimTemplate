using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_122 : SimTemplate //* 神秘获奖者 Mystery Winner
	{
		//<b>Battlecry:</b> <b>Discover</b> a <b>Secret.</b>
		//<b>战吼：</b><b>发现</b>一张<b>奥秘</b>牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
		}
		
	}
}
