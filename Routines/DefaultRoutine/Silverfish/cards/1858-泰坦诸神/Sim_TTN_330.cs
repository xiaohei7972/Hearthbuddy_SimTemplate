using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：6 生命值：10
	//Kologarn
	//科隆加恩
	//[x]<b>Rush</b>. Whenever this attacksa minion, put it in your hand.<b>Deathrattle:</b> Move any in your__hand to your opponent's.
	//<b>突袭</b>。每当本随从攻击随从时，将被攻击的随从放入你的手牌。<b>亡语：</b>将还在你手牌的这些随从牌移至对手的手牌。
	class Sim_TTN_330 : SimTemplate
	{
		public override void onMinionAttack(Playfield p, Minion attacker, Minion target)
		{
			base.onMinionAttack(p, attacker, target);
			if (target != null)
			{
				if (target.handcard.card.type == CardDB.cardtype.MOB)
				{
					p.minionReturnToHand(target, attacker.own, 0);
				}
			}
		}
		public override void onDeathrattle(Playfield p, Minion m)
		{
			base.onDeathrattle(p, m);
		}

	}
}
