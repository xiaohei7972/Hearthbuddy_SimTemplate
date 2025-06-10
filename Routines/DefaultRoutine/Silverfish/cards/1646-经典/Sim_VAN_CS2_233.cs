using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_233 : SimTemplate //* 剑刃乱舞 Blade Flurry
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = (ownplay) ? p.getSpellDamageDamage(p.ownWeapon.Angr) : p.getEnemySpellDamageDamage(p.enemyWeapon.Angr);

            p.allCharsOfASideGetDamage(!ownplay, damage);
            //destroy own weapon
            p.lowerWeaponDurability(1000, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
    }
}
