using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_032 : SimTemplate //* 烈焰风暴 Flamestrike
	{
		//Deal $5 damage to all enemy minions.
		//对所有敌方随从造成$5点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
			};
		}

	}
}