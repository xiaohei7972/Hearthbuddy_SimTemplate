using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_075a : SimTemplate //* 大 More!
	{
		//Guess that the next card costs more.
		//猜测下一张牌法力值消耗较大。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.ueberladung += 2;
		}
	}
}
