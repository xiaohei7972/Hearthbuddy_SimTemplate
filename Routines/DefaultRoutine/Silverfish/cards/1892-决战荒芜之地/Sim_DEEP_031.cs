using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：6
	//Chaos Creation
	//混乱化形
	//Deal $6 damage.Summon a random 6-Costminion. Destroy the bottom6 cards of your deck.
	//造成$6点伤害。随机召唤一个法力值消耗为（6）的随从。摧毁你牌库底的6张牌。
	class Sim_DEEP_031 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				// 计算实际伤害
				int dmg = ownplay ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);

				// 对目标造成伤害
				p.minionGetDamageOrHeal(target, dmg);

				// 使用 Playfield 的方法获取一个随机的同法力值消耗的随从
				CardDB.Card randomMinion = p.getRandomCardForManaMinion(6);

				// 如果找到有效的随从卡牌，则召唤该随从
				p.callKid(randomMinion, p.ownMinions.Count, ownplay);

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
			};
		}

	}
}
