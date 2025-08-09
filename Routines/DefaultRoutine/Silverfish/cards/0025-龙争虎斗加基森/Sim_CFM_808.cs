using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：5 生命值：4
	//Genzo, the Shark
	//“鲨鱼”加佐
	//Whenever this attacks, both players draw until they have 3 cards.
	//每当本随从攻击时，双方玩家抽若干数量的牌，直到拥有三张手牌。
	class Sim_CFM_808 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			while (p.owncards.Count < 3 && p.ownDeckSize > 0)
			{
				p.drawACard(CardDB.cardNameEN.unknown, true, true);
			}
			while (p.enemyAnzCards < 3 && p.enemyDeckSize > 0)
			{
				p.drawACard(CardDB.cardNameEN.unknown, false, true);
			}
		}

	}
}
