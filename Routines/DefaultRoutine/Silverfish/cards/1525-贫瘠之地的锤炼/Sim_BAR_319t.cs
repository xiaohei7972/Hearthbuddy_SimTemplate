using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_319t : SimTemplate //* 邪恶挥刺（等级2） Wicked Stab (Rank 2)
	{
		//Deal $4 damage. <i>(Upgrades when you have 10 Mana.)</i>
		//造成$4点伤害。<i>（当你有10点法力值时升级。）</i>
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}

		
	