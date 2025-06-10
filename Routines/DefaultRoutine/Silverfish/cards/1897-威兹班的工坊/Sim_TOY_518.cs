using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_518 : SimTemplate // 宝藏经销商 Treasure Distributor
    {
        // 在你召唤一个海盗后，使它和本随从各获得+1攻击力。

        // 这个方法在随从被召唤时触发
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            // 使用 Playfield 中的 IsRaceOrAll 方法检查召唤的随从是否是海盗或融合怪，并且是否属于自己的阵营
            if (summonedMinion.own == m.own && RaceUtils.IsRaceOrAll((CardDB.Race)summonedMinion.handcard.card.race, CardDB.Race.PIRATE))
            {
                // 对召唤的海盗随从增加1点攻击力
                p.minionGetBuffed(summonedMinion, 1, 0);

                // 对触发效果的本随从（宝藏经销商）增加1点攻击力
                p.minionGetBuffed(m, 1, 0);
            }
        }
    }
}