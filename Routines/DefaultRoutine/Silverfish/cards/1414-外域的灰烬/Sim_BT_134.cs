using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_134 : SimTemplate //* 沼泽射线 Bogbeam
	{
        //Deal $3 damage to_a minion.Costs (0) if you have at least 7 Mana Crystals.
        //对一个随从造成$3点伤害。如果你拥有至少七个法力水晶，则法力值消耗为（0）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
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
