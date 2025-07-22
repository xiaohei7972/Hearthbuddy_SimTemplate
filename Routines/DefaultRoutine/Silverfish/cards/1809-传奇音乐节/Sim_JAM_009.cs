using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 圣骑士 费用：2
	//Dance Floor
	//闪亮舞池
	//[x]Give your minions <b>Rush</b>.
	//使你的所有随从获得<b>突袭</b>。
	class Sim_JAM_009 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 遍历己方所有随从并赋予突袭
            foreach (Minion m in p.ownMinions)
            {
                m.rush = 1; // 赋予突袭 (rush = 1)
            }
        }
    }
}
