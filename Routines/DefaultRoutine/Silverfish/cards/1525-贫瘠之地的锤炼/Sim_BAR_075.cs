using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_075 : SimTemplate //* 十字路口哨所 Crossroads Watch Post
	{
        //[x]Can't attack. Whenever youropponent casts a spell, giveyour minions +1/+1.
        //无法攻击。每当你的对手施放一个法术，使你的所有随从获得+1/+1。

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (!triggerEffectMinion.silenced)
            {
                triggerEffectMinion.cantAttack = true;
                triggerEffectMinion.updateReadyness();
            }
        }

    }
}
