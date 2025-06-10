using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	class Sim_SCH_149 : SimTemplate //* 银色自大狂 Argent Braggart
	{
		//<b>Battlecry:</b> Gain Attack and Health to match the highest in the battlefield.
		//<b>战吼：</b>获得攻击力和生命值，使其与战场上最高的数值相同。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			List<Minion> temp1 = new List<Minion>(p.enemyMinions);
			List<Minion> temp2 = new List<Minion>(p.ownMinions);
			List<Minion> temp = temp1.Concat(temp2).ToList<Minion>();
			int atk = 1;
			int hp = 1;
			if(temp.Count > 0)
            {
				temp.Sort((a, b) => b.Angr.CompareTo(a.Angr));
				atk = temp[0].Angr;

				temp.Sort((a, b) => b.Hp.CompareTo(a.Hp));
				hp = temp[0].Hp;

				p.minionSetAngrToX(own, atk);
				p.minionSetLifetoX(own, hp);
				p.evaluatePenality += 30-atk/2-hp;

				if(hp >= 6) p.evaluatePenality -= 50;
			}
		}
	}
}
