using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：3
	//Wish of the New Moon
	//新月祈愿
	//Deal $6 damage to a minion. <i>(Cast @ |4(spell, spells) to gain <b>Lifesteal</b>.)</i>
	//对一个随从造成$6点伤害。<i>（施放@个法术以获得<b>吸血</b>。）</i>
	class Sim_EDR_460 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);
				p.minionGetDamageOrHeal(target, damage);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
			};
		}

	}
}
