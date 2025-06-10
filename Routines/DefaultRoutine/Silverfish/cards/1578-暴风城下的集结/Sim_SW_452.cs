using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_452 : SimTemplate //* 混乱吸取 Chaos Leech
	{
		//<b>Lifesteal</b>. Deal $3 damage to a minion.<b>Outcast:</b> Deal $5 instead.
		//<b>吸血</b>对一个随从造成$3点伤害。<b>流放：</b>改为造成$5点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            int heal = 3;
			p.minionGetDamageOrHeal(target, dmg);
            p.applySpellLifesteal(heal, ownplay);
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }

    }
}
