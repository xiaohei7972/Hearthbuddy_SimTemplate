using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_753 : SimTemplate //* 法力燃烧 Mana Burn
	{
		//Your opponent has 2 fewer Mana Crystals next turn.
		//下个回合，你的对手减少两个法力水晶。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay) p.enemyMaxMana -= Math.Max(0, p.enemyMaxMana - 2);
			else p.ownMaxMana -= Math.Max(0, p.ownMaxMana - 2);
		}

	}
}
