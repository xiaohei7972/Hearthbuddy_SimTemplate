using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_412 : SimTemplate //* 军情七处的要挟 SI:7 Extortion
	{
		//<b>Tradeable</b>Deal $3 damage to an undamaged character.
		//<b>可交易</b>对一个未受伤的角色造成$3点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.minionGetDamageOrHeal(target, dmg);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_UNDAMAGED_TARGET),
			};
		}
	}
}
