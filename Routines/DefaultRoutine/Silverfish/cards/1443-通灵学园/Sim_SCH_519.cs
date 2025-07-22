using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_519 : SimTemplate //* 狐人淬毒师 Vulpera Toxinblade
	{
        //Your weapon has +2_Attack.
        //你的武器获得+2攻击力。
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.minionGetBuffed(p.ownHero, 2, 0);
                    p.ownWeapon.Angr += 2;
                }
            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.enemyWeapon.Angr += 2;
                    p.minionGetBuffed(p.enemyHero, 2, 0);
                }
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.minionGetBuffed(p.ownHero, -2, 0);
                    p.ownWeapon.Angr -= 2;
                }
            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.enemyWeapon.Angr -= 2;
                    p.minionGetBuffed(p.enemyHero, -2, 0);
                }
            }
        }
    }
}
