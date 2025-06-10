using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_027 : SimTemplate //* 套索射击 Bola Shot
	{
		//Deal $1 damage to a minion and $2 damage to its neighbors.
		//对一个随从造成$1点伤害，并对其相邻的随从造成$2点伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = p.getSpellDamageDamage(3);
			p.minionGetDamageOrHeal(target, dmg);
			p.ownHero.Angr += 3;
			p.ownHero.updateReadyness();
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
		}

	}
}
