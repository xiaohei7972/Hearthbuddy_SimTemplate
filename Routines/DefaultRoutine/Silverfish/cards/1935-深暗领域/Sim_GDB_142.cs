using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：100 攻击力：15 生命值：15
	//The Ceaseless Expanse
	//无界空宇
	//[x]Costs (1) less for each timea card was drawn, played, ordestroyed. <b>Battlecry:</b> Destroyall other minions.
	//每当一张牌被抽到，使用或摧毁时，本牌的法力值消耗便减少（1）点。<b>战吼：</b>消灭所有其他随从。
	class Sim_GDB_142 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			foreach (Minion m in p.ownMinions)
            {
                if (m.entitiyID != own.entitiyID) p.minionGetDestroyed(m);															
            }
            foreach (Minion m in p.enemyMinions)
            {
                if (m.entitiyID != own.entitiyID) p.minionGetDestroyed(m);
            }
		}
		
	}
}
