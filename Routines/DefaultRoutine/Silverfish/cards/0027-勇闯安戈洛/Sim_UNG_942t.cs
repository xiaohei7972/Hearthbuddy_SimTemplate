using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_942t : SimTemplate //* 老鲨嘴 Megafin
//<b>Battlecry:</b> Fill your hand with random Murlocs.
//<b>战吼：</b>随机将鱼人牌置入你的手牌，直到你的手牌数量达到上限。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.owncarddraw += 10 - p.owncards.Count;
			}
		}
	}
}