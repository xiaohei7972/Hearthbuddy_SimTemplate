using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Headhunt
	//猎头
	//Deal $2 damage. Get a 4/4 Crewmate with a random <b>Bonus Effect</b>.
	//造成$2点伤害。获取一张4/4并具有一项随机<b>额外效果</b>的乘务员。
	class Sim_GDB_473 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				// 对一个随从造成4点伤害
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardIDEnum.GDB_471t, ownplay, true);
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
