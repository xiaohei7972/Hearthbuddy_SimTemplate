using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：3
	//Tindral Sageswift
	//丁达尔·迅贤
	//[x]<b>Deathrattle:</b> Deal 1 damageto all enemies. If it's youropponent's turn, deal4 damage instead.
	//<b>亡语：</b>对所有敌人造成1点伤害。如果此时是你对手的回合，改为造成4点。
	class Sim_FIR_958 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			//判断此随从是否为我方随从
			int damage = (m.own) ? (p.isOwnTurn ? 1 : 4) : (p.isOwnTurn ? 4 : 1);
			p.allCharsOfASideGetDamage(!m.own, damage);

		}

	}
}
