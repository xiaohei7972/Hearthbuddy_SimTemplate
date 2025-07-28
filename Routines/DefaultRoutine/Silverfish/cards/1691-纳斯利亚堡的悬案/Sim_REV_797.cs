using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //地标 恶魔猎手 费用：3
    //Relic Vault
    //圣物仓库
    //[x]{0}{1}
    //{0}{1}
    class Sim_REV_797 : SimTemplate
    {
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
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
}
