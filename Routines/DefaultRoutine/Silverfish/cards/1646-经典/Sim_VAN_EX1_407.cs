using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_407 : SimTemplate //* Brawl
	{
        // Destroy all minions except one. (chosen randomly) 破坏所有怪兽，以期望修正

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int maxVal = 0;
            int objectId = 0;

            // 找到最大
            foreach (Minion m in p.enemyMinions)
            {
                if(m.Angr + m.Hp > maxVal)
                {
                    maxVal = m.Angr + m.Hp;
                    objectId = m.entitiyID;
                }
            }
            
            // 破坏其他怪兽
            foreach (Minion m in p.enemyMinions)
            {
                p.evaluatePenality += Ai.Instance.botBase.getEnemyMinionValue(m, p) / (p.enemyMinions.Count + p.ownMinions.Count);
                p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                p.minionGetDestroyed(m);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_TOTAL_MINIONS, 2),
            };
        }
	}
}