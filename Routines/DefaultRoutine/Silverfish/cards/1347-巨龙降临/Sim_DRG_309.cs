using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_309 : SimTemplate //* 时光巨龙诺兹多姆 Nozdormu the Timeless
	{
		//<b>Battlecry:</b> Set each player to 10 Mana Crystals.
		//<b>战吼：</b>将双方玩家的法力水晶重置为十个。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				p.mana = Math.Min(10, p.mana + 10);
				p.ownMaxMana = Math.Min(10, p.ownMaxMana + 10);
			}
			else
			{
				p.mana = Math.Min(10, p.mana + 10);
				p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 10);
			}
		}
	}
}