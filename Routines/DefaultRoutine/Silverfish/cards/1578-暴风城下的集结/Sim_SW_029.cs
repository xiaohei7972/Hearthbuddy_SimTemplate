using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_029 : SimTemplate //* 港口匪徒 Harbor Scamp
	{
		//<b>Battlecry:</b> Draw a Pirate.
		//<b>战吼：</b>抽一张海盗牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.OG_315, own.own);
		}

	}
}
