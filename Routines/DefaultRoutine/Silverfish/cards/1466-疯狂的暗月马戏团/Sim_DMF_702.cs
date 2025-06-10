using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_702 : SimTemplate //* 风暴打击 Stormstrike
	{
		//Deal $3 damage to a minion. Give your hero +3 Attack this turn.
		//对一个随从造成$3点伤害。在本回合中，使你的英雄获得+3攻击力。
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
