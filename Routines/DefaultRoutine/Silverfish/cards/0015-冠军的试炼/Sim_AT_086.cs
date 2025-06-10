using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_086 : SimTemplate //* 破坏者 Saboteur
//<b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
//<b>战吼：</b>下个回合敌方英雄技能的法力值消耗增加（5）点。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.enemyHeroPowerCostLessOnce += 5;
			else p.ownHeroPowerCostLessOnce += 5;
		}
	}
}