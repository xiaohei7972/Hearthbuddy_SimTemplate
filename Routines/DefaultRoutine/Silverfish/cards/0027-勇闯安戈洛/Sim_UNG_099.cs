using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_099 : SimTemplate //* 狂奔的魔暴龙 Charged Devilsaur
//<b>Charge</b><b>Battlecry:</b> Can't attack heroes this turn.
//<b>冲锋，战吼：</b>在本回合中无法攻击英雄。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            own.cantAttackHeroes = true;
		}

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner) triggerEffectMinion.cantAttackHeroes = false;
        }
    }
}