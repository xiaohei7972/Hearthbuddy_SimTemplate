using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_044 : SimTemplate //* 范达尔·鹿盔 Fandral Staghelm
//Your <b>Choose One</b> cards and powers have both effects combined.
//你的<b>抉择</b>牌和英雄技能可以同时拥有两种效果。 
	{
		

        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own) p.ownFandralStaghelm++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.ownFandralStaghelm--;
        }
	}
}