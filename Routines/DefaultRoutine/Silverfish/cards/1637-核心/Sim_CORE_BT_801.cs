using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_801 : SimTemplate //* 眼棱 Eye Beam
	{
        //<b>Lifesteal</b>. Deal $3 damage to a minion.<b>Outcast:</b> This costs (1).
        //<b>吸血</b>。对一个随从造成$3点伤害。<b>流放：</b>法力值消耗为（1）点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, bool outcast)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            int oldHp = target.Hp;
            p.minionGetDamageOrHeal(target, dmg);
            if (oldHp > target.Hp) p.applySpellLifesteal(oldHp - target.Hp, ownplay);
            if (outcast)
            {
                p.evaluatePenality -= 1;
            }
            else p.evaluatePenality += 3;
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
