
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 潜行者 费用：1 攻击力：1 生命值：2
	//Ship's Chirurgeon
	//随船外科医师
	//After you summon a minion, give it +1 Health.
	//在你召唤一个随从后，使其获得+1生命值。
    class Sim_WON_065 : SimTemplate // 避免报错
    {
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
            {
                p.minionGetBuffed(summonedMinion, 0, 1);
            }
        }

    }
}
