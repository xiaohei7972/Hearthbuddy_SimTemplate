using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_233 : SimTemplate //* 剑刃乱舞 Blade Flurry
	{
		//Destroy your weapon and deal its damage to all enemy minions.
		//摧毁你的武器，对所有敌方随从造成等同于其攻击力的伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = (ownplay) ? p.getSpellDamageDamage(p.ownWeapon.Angr) : p.getEnemySpellDamageDamage(p.enemyWeapon.Angr);

            p.allMinionOfASideGetDamage(!ownplay, damage);
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
