using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_149 : SimTemplate //* 暴虐食尸鬼 Ravaging Ghoul
//<b>Battlecry:</b> Deal 1 damage to all other minions.
//<b>战吼：</b>对所有其他随从造成1点伤害。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allMinionsGetDamage(1, own.entitiyID);
        }
	}
}