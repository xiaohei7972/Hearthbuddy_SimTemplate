using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：2 生命值：1
	//Sizzling Cinder
	//炽烈烬火
	//<b>Deathrattle:</b> Deal 2 damage randomly split among all enemies.
	//<b>亡语：</b>造成2点伤害，随机分配到所有敌人身上。
	class Sim_TLC_249 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
			p.allCharsOfASideGetRandomDamage(!m.own, 2);
        }
		
	}
}
