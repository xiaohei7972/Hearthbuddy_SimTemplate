using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：10 攻击力：6 生命值：12
	//Amplified Elekk
	//强音雷象
	//[x]<b>Taunt</b><b>Deathrattle:</b> Deal 3 damageto all enemy minions.
	//<b>嘲讽</b>。<b>亡语：</b>对所有敌方随从造成3点伤害。
	class Sim_ETC_086 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
			p.allMinionOfASideGetDamage(!m.own, 3);
        }
		
	}
}
