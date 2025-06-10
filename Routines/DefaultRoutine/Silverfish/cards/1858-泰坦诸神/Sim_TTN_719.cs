using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：2
	//From the Scrapheap
	//废料回收
	//Get three 1/1 <b>Magnetic</b> Sparkbots with random <b>bonus effects</b>.
	//获取三张1/1并具有<b>磁力</b>和随机<b>额外效果</b>的火花机器人。
	class Sim_TTN_719 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
		    p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
		    p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);	
		}	
		
	}
}
