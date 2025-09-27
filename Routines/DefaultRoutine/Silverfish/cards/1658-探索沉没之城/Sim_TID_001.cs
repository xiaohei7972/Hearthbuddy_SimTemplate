using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：1
	//Moonbeam
	//月光射线
	//Deal $1 damage to an enemy, twice.
	//对一个敌人造成$1点伤害两次。
	class Sim_TID_001 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);
				p.minionGetDamageOrHeal(target, damage);
				p.minionGetDamageOrHeal(target, damage);

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
