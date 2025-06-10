using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_075a2 : SimTemplate //* 小 Less!
	{
		//Guess that the next card costs less.
		//猜测下一张牌法力值消耗较小。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
	}
}
