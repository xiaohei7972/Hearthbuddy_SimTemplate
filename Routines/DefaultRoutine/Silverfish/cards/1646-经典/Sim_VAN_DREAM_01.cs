using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_DREAM_01 : SimTemplate //* 欢笑的姐妹 Laughing Sister
	{
		//Can't be targeted by spells or Hero Powers.
		//无法成为法术或英雄技能的目标。


        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.cantBeTargetedBySpellsOrHeroPowers = true;
        }
	}
}