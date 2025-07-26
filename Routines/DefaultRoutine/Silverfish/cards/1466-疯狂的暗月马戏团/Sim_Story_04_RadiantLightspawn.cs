using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：5 攻击力：4 生命值：6
	//Radiant Lightspawn
	//闪亮的光耀之子
	//<b>Taunt</b>. <b>Battlecry:</b> Reduce the Cost of your Librams by (2) this game.
	//<b>嘲讽，战吼：</b>在本局对战中，你的圣契的法力值消耗减少（2）点。
	class Sim_Story_04_RadiantLightspawn : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.libram += 2;
		}
		
	}
}
