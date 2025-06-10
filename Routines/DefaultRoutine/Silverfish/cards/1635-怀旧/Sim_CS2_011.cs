using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_011 : SimTemplate //* 野蛮咆哮 Savage Roar
	{
		//Give your characters +2_Attack this turn.
		//在本回合中，使你的所有角色获得+2攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion t in temp)
            {
                p.minionGetTempBuff(t, 2, 0);
            }
            p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 2, 0);
        }

    }
}