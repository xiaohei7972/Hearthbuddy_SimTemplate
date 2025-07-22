using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_05_MarkedShot : SimTemplate //* 标记射击 Marked Shot
	{
		//Deal $4 damage to_a_minion. <b>Discover</b>_a_spell.
		//对一个随从造成$4点伤害。<b>发现</b>一张法术牌。
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
