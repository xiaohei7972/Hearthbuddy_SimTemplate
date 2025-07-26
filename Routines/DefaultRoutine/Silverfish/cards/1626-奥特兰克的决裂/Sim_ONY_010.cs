using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Dragonbane Shot
	//灭龙射击
	//[x]Deal $2 damage.<b>Honorable Kill:</b> Add a Dragonbane Shotto your hand.
	//造成$2点伤害。<b>荣誉消灭：</b>将一张灭龙射击置入你的手牌。
	class Sim_ONY_010 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ONY_010);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				if (ownplay && damage == target.Hp)
				{
					p.evaluatePenality -= 30;
					p.drawACard(CardDB.cardIDEnum.ONY_010, ownplay, true);
				}
				else
				{
					p.evaluatePenality += 10;
				}

			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
        }

	}
}
