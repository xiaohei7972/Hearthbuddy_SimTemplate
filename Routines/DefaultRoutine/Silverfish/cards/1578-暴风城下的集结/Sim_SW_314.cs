using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_314 : SimTemplate //* 光明使者之锤 Lightbringer's Hammer
	{
        //<b>Lifesteal</b>Can't attack heroes.
        //<b>吸血</b>无法攻击英雄。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.cantAttackHeroes = true;
        }

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (m.own == turnEndOfOwner) m.cantAttackHeroes = true;
        }

    }
}
