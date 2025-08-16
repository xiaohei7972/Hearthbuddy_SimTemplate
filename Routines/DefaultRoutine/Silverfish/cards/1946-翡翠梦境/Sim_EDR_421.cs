using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：10 攻击力：6 生命值：12
	//Omen
	//年兽
	//[x]<b>Rush</b>, <b>Windfury</b><b>Deathrattle:</b> Deal @ damageto all enemies. <i>(Improvesafter this attacks!)</i>
	//<b>突袭</b>。<b>风怒</b><b>亡语：</b>对所有敌人造成@点伤害。<i>（在本随从攻击后提升！）</i>
	class Sim_EDR_421 : SimTemplate
	{
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			//增加tag2数据
			attacker.handcard.card.TAG_SCRIPT_DATA_NUM_1++;
		}
		public override void onDeathrattle(Playfield p, Minion m)
		{
			//根据tag2数据造成aoe伤害
			p.allCharsOfASideGetDamage(!m.own, m.handcard.card.TAG_SCRIPT_DATA_NUM_1);
		}
	}
}
