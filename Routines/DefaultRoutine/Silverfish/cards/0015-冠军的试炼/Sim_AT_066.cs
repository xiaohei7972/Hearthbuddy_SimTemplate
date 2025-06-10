using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_066 : SimTemplate //* 奥格瑞玛狼骑士 Orgrimmar Aspirant
//<b>Inspire:</b> Give your weapon +1 Attack.
//<b>激励：</b>使你的武器获得+1攻击力。 
	{
		

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                if (own)
                {
                    if (p.ownWeapon.Durability > 0) p.ownWeapon.Angr++;
                }
                else
                {
                    if (p.enemyWeapon.Durability > 0) p.enemyWeapon.Angr++;
                }
			}
        }
	}
}