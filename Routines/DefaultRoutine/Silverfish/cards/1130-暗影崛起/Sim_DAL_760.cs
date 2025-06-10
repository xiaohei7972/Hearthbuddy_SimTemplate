using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_760 : SimTemplate //* 推土壮汉 Burly Shovelfist
//<b>Rush</b>
//<b>突袭</b> 
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