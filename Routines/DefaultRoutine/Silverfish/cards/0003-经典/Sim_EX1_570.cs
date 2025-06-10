using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_570 : SimTemplate //* 撕咬 Bite
	{
		//Give your hero +4_Attack this turn. Gain 4 Armor.
		//使你的英雄获得4点护甲值，并在本回合中获得+4攻击力。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 4, 0);
                p.minionGetArmor(p.ownHero, 4);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 4, 0);
                p.minionGetArmor(p.enemyHero, 4);

            }
		}

	}
}