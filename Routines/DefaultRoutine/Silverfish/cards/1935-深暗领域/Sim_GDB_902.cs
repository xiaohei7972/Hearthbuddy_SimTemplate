using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Infiltrate
	//潜入
	//Choose a minion.Deal $3 damage to all other minions.
	//选择一个随从。对所有其他随从造成$3点伤害。
	class Sim_GDB_902 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				// 对一个随从造成4点伤害
				p.allMinionsGetDamage(damage, target.entitiyID);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}
		
	}
}
