using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_105 : SimTemplate //* 英勇打击 Heroic Strike
	{
		//Give your hero +4_Attack this turn.
		//在本回合中，使你的英雄获得+4攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 4, 0);

        }

    }
}