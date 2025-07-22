using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_EX1_169 : SimTemplate //* 激活 Innervate
	{
		//Gain 1 Mana Crystal this turn only.
		//在本回合中，获得一个法力水晶。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.mana = Math.Min(10, p.mana+1);
		}
		
	}
}
