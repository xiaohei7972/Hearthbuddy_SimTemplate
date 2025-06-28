using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：1
	//Conflagrate
	//焚烧
	//Deal $5 damage to a minion. Its owner draws a card.
	//对一个随从造成$5点伤害，其拥有者抽一张牌。
	class Sim_FIR_954 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
				p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, damage);
				p.drawACard(CardDB.cardNameEN.unknown, target.own, false);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从
			};
		}
		
	}
}
