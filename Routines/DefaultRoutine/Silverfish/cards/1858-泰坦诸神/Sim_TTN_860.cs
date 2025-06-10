using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：2
	//Drone Deconstructor
	//无人机拆解器
	//[x]<b>Battlecry:</b> Get a 1/1<b>Magnetic</b> Sparkbot with arandom <b>bonus effect</b>.
	//<b>战吼：</b>获取一张1/1并具有<b>磁力</b>和一项随机<b>额外效果</b>的火花机器人。
	class Sim_TTN_860 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.lepergnome, own.own, true);
		}
		
	}
}
