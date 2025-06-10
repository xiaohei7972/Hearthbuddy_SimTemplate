using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_HERO_06bp : SimTemplate //* 变形 Shapeshift
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                if (p.ownHero.Angr == 0)
                {
                    p.ownHero.Ready = true;
                }
                p.minionGetTempBuff(p.ownHero, 1, 0);
                p.minionGetArmor(p.ownHero,1);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 1, 0);
                p.minionGetArmor(p.enemyHero,1);
            }
        }


	}
}