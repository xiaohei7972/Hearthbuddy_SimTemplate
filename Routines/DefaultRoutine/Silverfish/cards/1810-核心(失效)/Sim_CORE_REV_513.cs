using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：4 攻击力：4 生命值：4
	//Chatty Bartender
	//健谈的调酒师
	//[x]At the end of your turn,if you control a <b>Secret</b>,deal 2 damage toall enemies.
	//在你的回合结束时，如果你控制一个<b>奥秘</b>，对所有敌人造成2点伤害。
	class Sim_CORE_REV_513 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int b = (turnEndOfOwner) ? p.ownSecretsIDList.Count : p.enemySecretCount;
                if (b >= 1) p.allCharsOfASideGetDamage(!triggerEffectMinion.own, 2);

            }
        }
		
	}
}
