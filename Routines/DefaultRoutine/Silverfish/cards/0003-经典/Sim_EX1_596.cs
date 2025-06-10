using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_596 : SimTemplate //* 恶魔之火 Demonfire
	{
		//Deal $2 damage to a minion. If it’s a friendly Demon, give it +2/+2 instead.
		//对一个随从造成$2点伤害，如果该随从是友方恶魔，则改为使其获得+2/+2。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target.handcard.card.race == CardDB.Race.DEMON && ownplay == target.own)
            {
                p.minionGetBuffed(target, 2, 2);
            }
            else
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
            }
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