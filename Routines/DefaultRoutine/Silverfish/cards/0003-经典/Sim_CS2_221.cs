using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_221 : SimTemplate //* 恶毒铁匠 Spiteful Smith
	{
		//Your weapon has +2 Attack while this is damaged.
		//该随从受到伤害时使你的武器获得+2攻击力。
        public override void onEnrageStart(Playfield p, Minion m)
        {
            if (m.own)
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

        public override void onEnrageStop(Playfield p, Minion m)
        {
            if (m.own)
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