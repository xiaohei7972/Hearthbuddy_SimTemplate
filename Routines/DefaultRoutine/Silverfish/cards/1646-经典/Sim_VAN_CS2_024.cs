using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_024 : SimTemplate //* 寒冰箭 Frostbolt
	{
		//Deal $3 damage to a_character and <b>Freeze</b> it.
		//对一个角色造成$3点伤害，并使其<b>冻结</b>。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetFrozen(target);
            p.minionGetDamageOrHeal(target,dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
