using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：3
	//Anti-Magic Shell
	//反魔法护罩
	//Give your minions +1/+1 and <b>Elusive</b>.
	//使你的所有随从获得+1/+1和<b>扰魔</b>。
	class Sim_RLK_Prologue_RLK_048 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
			{
				p.minionGetBuffed(minion, 1, 1);
				minion.Elusive = true;
			}
        }
		
	}
}
