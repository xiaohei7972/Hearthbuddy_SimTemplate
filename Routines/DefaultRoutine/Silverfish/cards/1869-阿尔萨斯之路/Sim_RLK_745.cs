using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_745 : SimTemplate //* 恶毒恐魔 Malignant Horror
    {
        //[x]<b>Reborn</b> At the end of your turn, spend 4 <b>Corpses</b> to summon a copy of this minion.
        //<b>复生</b>。在你的回合结束时，消耗4份<b>残骸</b>，召唤一个本随从的复制。
        
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner /*&& p.ownCorpses >= 4*/)
            {
                //p.ownCorpses -= 4; // 消耗4份残骸
                p.callKid(triggerEffectMinion.handcard.card, triggerEffectMinion.zonepos, turnEndOfOwner);
                
                List<Minion> temp = (turnEndOfOwner) ? p.ownMinions : p.enemyMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.entitiyID != triggerEffectMinion.entitiyID && mnn.handcard.card == triggerEffectMinion.handcard.card)
                    {
                        mnn.setMinionToMinion(triggerEffectMinion); // 复制本随从的所有属性
                        break;
                    }
                }
            }
        }
    }
}
