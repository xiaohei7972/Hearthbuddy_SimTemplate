using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BTA_13 : SimTemplate //* 邪变 Deteriorate
	{
        //[x]Deal $3 damage to a minion.If it dies, summon a 3/3Imprisoned Scrap Imp.
        //对一个随从造成$3点伤害。如果该随从死亡，则召唤一个3/3的被禁锢的拾荒小鬼。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
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
