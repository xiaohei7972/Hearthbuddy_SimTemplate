using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：6 攻击力：4 生命值：8
	//Testing Dummy
	//测试假人
	//<b>Taunt</b><b>Deathrattle:</b> Deal 8damage randomly split among all enemies.
	//<b>嘲讽</b>。<b>亡语：</b>造成8点伤害，随机分配到所有敌人身上。
	class Sim_TOY_606 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			// 使用现有的 allCharsOfASideGetRandomDamage 方法对敌方角色造成 8 点随机伤害
			p.allCharsOfASideGetRandomDamage(!m.own, 8);
		}

	}
}
