using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_717 : SimTemplate //* 火焰之灾祸 Plague of Flames
	{
        //[x]Destroy all your minions.For each one, destroy arandom enemy minion.
        //消灭你的所有随从。每消灭一个随从，便随机消灭一个敌方随从。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int count = p.ownMinions.Count;
            int countEnemy = p.enemyMinions.Count;
            if (count <= 0 || countEnemy <= 0)
            {
                p.evaluatePenality += 1000;
                return;
            }
            foreach(Minion m in p.ownMinions.ToArray())
            {
                p.minionGetDestroyed(m);
            }
            int val = 0;
            foreach (Minion m in p.enemyMinions.ToArray())
            {
                val += Ai.Instance.botBase.getEnemyMinionValue(m, p);
                p.minionGetDestroyed(m);
            }
            if (countEnemy > count)
            {
                p.evaluatePenality += val * (countEnemy - count) / countEnemy;
            }
        }

    }
}
