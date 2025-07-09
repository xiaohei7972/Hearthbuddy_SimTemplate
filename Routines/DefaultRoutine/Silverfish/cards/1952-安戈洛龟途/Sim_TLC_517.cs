using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Knockback
	//一脚踢飞
	//[x]Deal $@ damage toa minion <i>(improved foreach time you've shuffledcards into your deck)</i>.
	//对一个随从造成$@点伤害<i>（你每将卡牌洗入牌库一次都会提升）</i>。
	class Sim_TLC_517 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				//TODO:兄弟playfiled还没记录洗入次数的属性,就先这样写了
				int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.minionGetDamageOrHeal(target, damage);
			}

		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}
	}
}
