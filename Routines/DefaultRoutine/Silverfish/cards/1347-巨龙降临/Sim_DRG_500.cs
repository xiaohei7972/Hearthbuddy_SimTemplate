using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_500 : SimTemplate //* 熔火吐息 Molten Breath
	{
        //[x]Deal $5 damage to aminion. If you're holdinga Dragon, gain 5 Armor.
        //对一个随从造成$5点伤害。如果你的手牌中有龙牌，便获得5点护甲值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(5);
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
