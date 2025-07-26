using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//* 奥尔多侍从 Aldor Attendant
	//<b>Battlecry:</b> Reduce the Cost_of your Librams by_(1) this game.
	//<b>战吼：</b>在本局对战中，你的圣契的法力值消耗减少（1）点。
	class Sim_BT_020 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.libram += 1;
		}

	}
}
