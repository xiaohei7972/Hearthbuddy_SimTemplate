using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_341 : SimTemplate //* 骸骨巨龙 Skeletal Dragon
	{
		//[x]<b>Taunt</b>At the end of your turn, adda Dragon to your hand.
		//<b>嘲讽</b>在你的回合结束时，将一张龙牌置入你的手牌。
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (triggerEffectMinion.own == turnEndOfOwner)
			{
				p.drawACard(CardDB.cardIDEnum.None, turnEndOfOwner, true);
			}
		}

	}
}
