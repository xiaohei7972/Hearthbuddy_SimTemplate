using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_801 : SimTemplate //* 眼棱 Eye Beam
	{
        //<b>Lifesteal</b>. Deal $3 damage to a minion.<b>Outcast:</b> This costs (1).
        //<b>吸血</b>。对一个随从造成$3点伤害。<b>流放：</b>法力值消耗为（1）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetDamageOrHeal(p.ownHero, -dmg);
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
