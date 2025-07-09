using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Cryosleep
	//封冻沉眠
	//Deal $4 damageand draw a card.<b>Kindred: </b>Draw another.
	//造成$4点伤害并抽一张牌。<b>延系：</b>再抽一张。
	class Sim_TLC_440 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardNameEN.unknown, ownplay);
				//TODO:有延系方法再加上额外抽牌
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
