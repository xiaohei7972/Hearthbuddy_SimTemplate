using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：5 攻击力：4 生命值：5
	//Twilight Medium
	//暮光灵媒师
	//[x]<b>Taunt</b><b>Battlecry:</b> Set the Cost of thetop card of your deck to (1).
	//<b>嘲讽</b>。<b>战吼：</b>将你牌库顶的一张牌的法力值消耗变为（1）点。
	class Sim_VAC_423 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

		}
	}
}
