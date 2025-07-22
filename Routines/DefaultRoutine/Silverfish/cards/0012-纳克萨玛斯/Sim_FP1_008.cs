using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_008 : SimTemplate //* 鬼灵骑士 Spectral Knight
//Can't be targeted by spells or Hero Powers.
//无法成为法术或英雄技能的目标。 
	{


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.cantBeTargetedBySpellsOrHeroPowers = true;
        }
	}
}