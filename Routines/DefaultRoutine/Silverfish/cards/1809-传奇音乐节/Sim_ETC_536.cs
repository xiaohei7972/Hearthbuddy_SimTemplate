using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：2 攻击力：3 生命值：2
	//Audio Splitter
	//音频切分机
	//<b>Deathrattle:</b> Copy thehighest Cost spell inyour hand.
	//<b>亡语：</b>复制你手牌中法力值消耗最高的法术牌。
	class Sim_ETC_536 : SimTemplate
	{
		public override void onDeathrattle(Playfield p, Minion m)
		{

			p.drawACard(CardDB.cardIDEnum.None, m.own);
			

			
		}
		
	}
}
