using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 无效的 费用：2
	//Photon Cannon
	//光子炮台
	//Deal $3 damage.If this kills a minion, your Protoss minions cost (1) less this game.
	//造成$3点伤害。如果本牌消灭了一个随从，则在本局对战中，你的星灵随从牌的法力值消耗减少（1）点。
	class Sim_SC_753 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
			};

		}

	}
}
