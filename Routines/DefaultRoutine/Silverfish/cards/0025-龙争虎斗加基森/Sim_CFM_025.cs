using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：5 生命值：5
	//Wind-up Burglebot
	//发条强盗机器人
	//Whenever this attacks a minion and survives, draw_a card.
	//每当本随从攻击随从并存活下来时，抽一张牌。
	class Sim_CFM_025 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (!defender.isHero && attacker.Hp > 0)
				p.drawACard(CardDB.cardNameEN.unknown, attacker.own);

		}

	}
}
