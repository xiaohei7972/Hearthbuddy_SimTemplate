using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：7 生命值：5
	//Therazane
	//塞拉赞恩
	//[x]<b>Taunt</b> <b>Deathrattle:</b> Double thestats of all Elementals inyour hand and deck.
	//<b>嘲讽</b>。<b>亡语：</b>使你手牌和牌库中的所有元素牌属性值翻倍。
	class Sim_DEEP_036 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{
			m.taunt = true;
			p.minionGetBuffed(m, m.Angr, m.Hp);
		}        
	}
}
