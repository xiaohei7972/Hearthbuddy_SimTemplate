using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 圣骑士 费用：3 攻击力：3 耐久度：0
	//Interstellar Starslicer
	//斩星巨刃
	//<b>Battlecry and Deathrattle:</b> Reduce the Cost of your Librams by (1)this game.
	//<b>战吼，亡语：</b>在本局对战中，你的圣契的法力值消耗减少（1）点。
	class Sim_GDB_726 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.libram += 1;
		}

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.libram += 1;
		}

	}
}
