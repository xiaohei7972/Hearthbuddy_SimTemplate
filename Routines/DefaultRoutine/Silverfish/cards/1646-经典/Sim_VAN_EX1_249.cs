using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_249 : SimTemplate //* 迦顿男爵 Baron Geddon
	{
		//At the end of your turn, deal 2 damage to ALL other characters.
		//在你的回合结束时，对所有其他角色造成2点伤害。

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.allCharsGetDamage(2, triggerEffectMinion.entitiyID);
            }
        }
	}
}