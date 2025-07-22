using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_005 : SimTemplate //* 爪击 Claw
	{
		//Give your hero +2_Attack this turn. Gain 2 Armor.
		//使你的英雄获得2点护甲值，并在本回合中获得+2攻击力。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 2);
                p.minionGetTempBuff(p.ownHero, 2, 0);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 2);
                p.minionGetTempBuff(p.enemyHero, 2, 0);
            }
		}

	}
}