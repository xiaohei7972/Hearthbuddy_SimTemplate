using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：1 攻击力：0 生命值：2
	//Strength Totem
	//力量图腾
	//At the end of your turn, give another friendly minion +1 Attack.
	//在你的回合结束时，使另一个友方随从获得+1攻击力。
	class Sim_AT_132_SHAMANe : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                List<Minion> tmp = triggerEffectMinion.own ? p.ownMinions : p.enemyMinions;
                foreach (Minion m in tmp)
                {
                    if (triggerEffectMinion.entitiyID == m.entitiyID) continue;
                    p.minionGetBuffed(m, 1, 0);
                    break;
                }
            }
        }
		
	}
}
