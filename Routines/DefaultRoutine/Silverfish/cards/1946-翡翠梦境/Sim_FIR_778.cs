using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：9 攻击力：9 生命值：9
	//Avatar of Destruction
	//毁灭化身
	//[x]<b>Taunt</b><b>Deathrattle:</b> Deal 9 damageto all enemy minions.
	//<b>嘲讽</b><b>亡语：</b>对所有敌方随从造成9点伤害。
	class Sim_FIR_778 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.allMinionOfASideGetDamage(!m.own,9);
        }
		
	}
}
