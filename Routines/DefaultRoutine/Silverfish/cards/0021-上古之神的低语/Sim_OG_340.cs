using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_340 : SimTemplate //* 深渊滑行者索苟斯 Soggoth the Slitherer
//<b>Taunt</b>Can't be targeted by spells or Hero Powers.
//<b>嘲讽</b>无法成为法术或英雄技能的目标。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            own.cantBeTargetedBySpellsOrHeroPowers = true;
        }
	}
}