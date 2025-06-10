using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_114 : SimTemplate //* 强行透支 Overdraft
	{
		//[x]<b>Tradeable</b>Unlock your <b>Overloaded</b>Mana Crystals to dealthat much damage.
		//<b>可交易</b>解锁你<b>过载</b>的法力水晶，并造成等量的伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int x = p.ueberladung;
			int dmg = (ownplay) ? p.getSpellDamageDamage(x) : p.getEnemySpellDamageDamage(x);
			p.minionGetDamageOrHeal(target, dmg);
			if (ownplay) p.unlockMana();
		}

		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
