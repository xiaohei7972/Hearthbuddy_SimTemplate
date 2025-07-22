using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_014 : SimTemplate //* 星占师 Starscryer
	{
		//<b>Deathrattle:</b> Draw a spell.
		//<b>亡语：</b>抽一张法术牌。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.drawACard(CardDB.cardIDEnum.None, m.own);
		}

	}
}
