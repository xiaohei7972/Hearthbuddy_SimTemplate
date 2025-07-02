using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：3 生命值：3
	//Shimmering Courser
	//闪光的骏马
	//<b>Elusive</b> on your opponent's turn.
	//在你对手的回合<b>扰魔</b>。
	class Sim_LOOT_193 : SimTemplate
	{

		// Minion还没写扰魔属性

		// public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		// {
		// 	if (triggerEffectMinion.own == !turnStartOfOwner)
		// 	{
		// 		triggerEffectMinion.elusive = true;
		// 	}
		// }


        // public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        // {
        //     if (triggerEffectMinion.own == !turnStartOfOwner)
		// 	{
		// 		triggerEffectMinion.elusive = flase;
		// 	}
        // }

	}
}
