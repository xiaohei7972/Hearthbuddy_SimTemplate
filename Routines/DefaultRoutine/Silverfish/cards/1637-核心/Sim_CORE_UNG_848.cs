using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：4 生命值：8
	//Primordial Drake
	//始生幼龙
	//[x]<b>Taunt</b><b>Battlecry:</b> Deal 2 damageto all other minions.
	//<b>嘲讽，战吼：</b>对所有其他随从造成2点伤害。
	class Sim_CORE_UNG_848 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.allMinionsGetDamage(2, own.entitiyID);
        }
		
	}
}
