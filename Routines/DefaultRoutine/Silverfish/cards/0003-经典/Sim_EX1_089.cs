using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_089 : SimTemplate //* 奥术傀儡 Arcane Golem
	{
		//<b>Charge</b>. <b>Battlecry:</b> Give your opponent a Mana Crystal.
		//<b>冲锋</b>，<b>战吼：</b>使你的对手获得一个法力水晶。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.enemyMaxMana = Math.Min(10, p.enemyMaxMana+1);
            }
            else
            {
                p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            }
		}


	}
}
