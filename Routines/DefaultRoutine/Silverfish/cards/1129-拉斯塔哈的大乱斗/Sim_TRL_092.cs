using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_092 : SimTemplate //* 鲨鱼之灵 Spirit of the Shark
//[x]<b>Stealth</b> for 1 turn.Your minions' <b>Battlecries</b>__and <b>Combos</b> trigger twice._
//<b>潜行</b>一回合。你的随从的<b>战吼</b>和<b>连击</b>触发两次。 
	{
		

		public override void onAuraStarts(Playfield p, Minion own)
		{
            if (own.own) p.ownBrannBronzebeard++;
            else p.enemyBrannBronzebeard++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own) p.ownBrannBronzebeard--;
            else p.enemyBrannBronzebeard--;
        }
	}
}
