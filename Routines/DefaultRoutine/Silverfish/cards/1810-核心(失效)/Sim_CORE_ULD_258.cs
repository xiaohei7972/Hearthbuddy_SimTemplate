using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：4 生命值：8
	//Armagedillo
	//硕铠鼠
	//[x]<b>Taunt</b>At the end of your turn,give all <b>Taunt</b> minionsin your hand +2/+2.
	//<b>嘲讽</b>在你的回合结束时，使你手牌中所有<b>嘲讽</b>随从牌获得+2/+2。
	class Sim_CORE_ULD_258 : SimTemplate
	{
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			if (turnEndOfOwner == triggerEffectMinion.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.tank)
					{
						hc.addattack += 2;
						hc.addHp += 2;
						p.anzOwnExtraAngrHp += 4;
					}
				}
			}
		}	
	}
}
