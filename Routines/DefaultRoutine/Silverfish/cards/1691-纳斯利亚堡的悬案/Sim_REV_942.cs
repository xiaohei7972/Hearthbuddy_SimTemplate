using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 恶魔猎手 费用：2
	//Relic Vault
	//圣物仓库
	//The next Relic you play this turn casts twice.
	//在本回合中你使用的下一个圣物将施放两次。
	class Sim_REV_942 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 设置一个标志，表示本回合的下一个圣物将施放两次
            if (triggerMinion.own)
            {
                p.ownRelicDoubleCast = true;
            }
            else
            {
                p.enemyRelicDoubleCast = true;
            }
        }
    }
}
