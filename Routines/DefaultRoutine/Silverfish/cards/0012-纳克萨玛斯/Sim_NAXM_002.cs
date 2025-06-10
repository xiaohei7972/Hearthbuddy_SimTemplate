using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAXM_002 : SimTemplate //* 骷髅铁匠 Skeletal Smith
//<b>Deathrattle:</b> Destroy your opponent's weapon.
//<b>亡语：</b>摧毁对手的武器。 
	{
		
		
		public override void onDeathrattle(Playfield p, Minion m)
		{
            p.lowerWeaponDurability(1000, !m.own);
		}
	}
}