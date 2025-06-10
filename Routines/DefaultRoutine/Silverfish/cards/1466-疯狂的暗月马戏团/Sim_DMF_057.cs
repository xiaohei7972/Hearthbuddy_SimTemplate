using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_057 : SimTemplate //* 月蚀 Lunar Eclipse
	{
		//Deal $3 damage to a minion. Your next spell this turn costs (2) less.
		//对一个随从造成$3点伤害。在本回合中，你施放的下一个法术的法力值消耗减少（2）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
			p.minionGetFrozen(target);
			p.minionGetDamageOrHeal(target, dmg);
			if (ownplay) p.playedPreparation = true;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
