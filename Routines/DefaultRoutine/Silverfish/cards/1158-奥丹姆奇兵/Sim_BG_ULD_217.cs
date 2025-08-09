using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：1 攻击力：1 生命值：2
	//Micro Mummy
	//微型木乃伊
	//[x]<b>Reborn</b>At the end of your turn, giveanother random friendlyminion +1 Attack.
	//<b>复生</b>在你的回合结束时，随机使另一个友方随从获得+1攻击力。
	class Sim_BG_ULD_217 : SimTemplate
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
