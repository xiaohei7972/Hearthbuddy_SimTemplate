using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_276 : SimTemplate //怪盗图腾
	{
		// 在你的回合结束时，将一张跟班牌置入你的手牌。
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.drawACard(CardDB.cardNameEN.koboldlackey, turnEndOfOwner, true);
			}
		}

	}
}