using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：6
	//Injured Tol'vir
	//受伤的托维尔人
	//<b>Taunt</b><b>Battlecry:</b> Deal 3 damage to this minion.
	//<b>嘲讽</b>。<b>战吼：</b>对本随从造成3点伤害。
	class Sim_CORE_ULD_271 : SimTemplate
		{
			public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
			{
				p.minionGetDamageOrHeal(own, 3); // 对该随从造成10点伤害
			}
			
		}
}
