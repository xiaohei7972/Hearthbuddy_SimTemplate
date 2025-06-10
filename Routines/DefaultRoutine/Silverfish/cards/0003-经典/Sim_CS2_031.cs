using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CS2_031 : SimTemplate //* 冰枪术 Ice Lance
//<b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead.
//使一个角色<b>冻结</b>，如果它已经被<b>冻结</b>，则改为对其造成$4点伤害。 
	{
        

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            
            if (target.frozen)
            {
                p.minionGetDamageOrHeal(target, dmg);
            }
            else
            {
                p.minionGetFrozen(target);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}