using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_081 : SimTemplate //* 纯洁者耶德瑞克 Eadric the Pure
//<b>Battlecry:</b> Change all enemy minions'Attack to 1.
//<b>战吼：</b>使所有敌方随从的攻击力变为1。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Minion m in p.enemyMinions)
				{
					p.minionSetAngrToX(m, 1);
				}
			}
			else
			{
				foreach (Minion m in p.ownMinions)
				{
					p.minionSetAngrToX(m, 1);
				}
			}				
		}
	}
}