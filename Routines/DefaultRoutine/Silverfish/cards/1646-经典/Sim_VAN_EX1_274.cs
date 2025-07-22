using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_274 : SimTemplate //* 虚灵奥术师 Ethereal Arcanist
	{
		//If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
		//如果在你的回合结束时，你控制一个<b>奥秘</b>，该随从便获得+2/+2。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int b = (turnEndOfOwner) ? p.ownSecretsIDList.Count : p.enemySecretCount;
                if (b >= 1) p.minionGetBuffed(triggerEffectMinion, 2, 2);
 
            }
        }

	}
}