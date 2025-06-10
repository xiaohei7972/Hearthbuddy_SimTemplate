using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_067 : SimTemplate //* 奖品商贩 Prize Vendor
	{
		//<b>Battlecry:</b> Both players draw a card.
		//<b>战吼：</b>每个玩家抽一张牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, true);
			p.drawACard(CardDB.cardIDEnum.None, false);
		}
	}
}
