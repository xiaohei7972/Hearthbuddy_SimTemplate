using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：6
	//Dirge of Despair
	//绝望哀歌
	//[x]Deal $3 damage to acharacter. If that kills it,summon a Demon fromyour deck.
	//对一个角色造成$3点伤害。如果消灭该角色，从你的牌库中召唤一个恶魔。
	class Sim_ETC_082 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				if (ownplay)
				{
					if (target.Hp < 0)
					{
						foreach (CardDB.Card card in p.ownDeck)
						{
							if (RaceUtils.MinionBelongsToRace(card.GetRaces(), CardDB.Race.DEMON))
							{
								int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
								p.callKid(card, pos, ownplay);
								break;
							}
						}

					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
			};
		}

	}
}
