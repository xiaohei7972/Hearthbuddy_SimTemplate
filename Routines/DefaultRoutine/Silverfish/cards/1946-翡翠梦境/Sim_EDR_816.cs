using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_EDR_816 : SimTemplate //* 怪异魔蚊 Monstrous Mosquito
    {
        //At the end of your turn, give your other minions +1 Attack.
        //在你的回合结束时，使你的其他随从获得+1攻击力。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> minions = turnEndOfOwner ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in minions)
                {
                    if (m.entitiyID != triggerEffectMinion.entitiyID) // 确保不buff自己
                    {
                        p.minionGetBuffed(m, 1, 0); // +1攻击力
                    }
                }
            }
        }
    }
}