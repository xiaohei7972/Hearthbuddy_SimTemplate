using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_210: SimTemplate //* 暗影升腾者 Shadow Ascendant
//[x]At the end of your turn,give another randomfriendly minion +1/+1.
//在你的回合结束时，随机使另一个友方随从获得+1/+1。 
    {
        

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> tmp = new List<Minion>(turnEndOfOwner ? p.ownMinions : p.enemyMinions);
                tmp.Sort((a, b) => a.Hp.CompareTo(b.Hp)); 
                foreach (Minion m in tmp)
                {
                    if (triggerEffectMinion.entitiyID == m.entitiyID) continue;
                    p.minionGetBuffed(m, 1, 1);
                    break;
                }
            }
        }
    }
}