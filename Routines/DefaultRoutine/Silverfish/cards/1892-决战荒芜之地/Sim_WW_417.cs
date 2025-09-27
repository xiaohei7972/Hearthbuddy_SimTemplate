using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：4 攻击力：4 生命值：3
	//Drilly the Kid
	//钻头小子
	//<b>Battlecry, Quickdraw,and Deathrattle:</b><b>Excavate</b> a treasure.
	//<b>战吼，快枪，亡语：</b><b>发掘</b>一个宝藏。
	class Sim_WW_417 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.drawACard(p.handleExcavation().cardIDenum, own.own, true);
        }

		public override void onDeathrattle(Playfield p, Minion m)
		{
			p.drawACard(p.handleExcavation().cardIDenum, m.own, true);
		}
	}
}
