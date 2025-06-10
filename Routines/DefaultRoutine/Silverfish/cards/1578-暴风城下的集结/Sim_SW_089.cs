using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_089 : SimTemplate //* 资深顾客 Entitled Customer
	{
		//<b>Battlecry:</b> Deal damage equal to your hand size to all other minions.
		//<b>战吼：</b>对所有其他随从造成等同于你手牌数量的伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int dmg = p.owncards.Count;
			p.allMinionsGetDamage(dmg, own.entitiyID);
		}
	}
}
