using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_848 : SimTemplate //* 始生幼龙 Primordial Drake
//[x]<b>Taunt</b><b>Battlecry:</b> Deal 2 damageto all other minions.
//<b>嘲讽，战吼：</b>对所有其他随从造成2点伤害。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allMinionsGetDamage(2, own.entitiyID);
        }
	}
}