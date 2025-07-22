using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：4 生命值：3
	//Eroded Sediment
	//侵蚀沉积岩
	//[x]<b>Battlecry:</b> If you playedan Elemental last turn,<b>Discover</b> any Elementalfrom the past.
	//<b>战吼：</b>如果你在上个回合使用过元素牌，<b>发现</b>一张来自过去的任意元素牌。
	class Sim_WW_428 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.pompousthespian, own.own, true);//这里错误！只是为了实现而写，参照 石丘防御者

        }
		
		
	}
}
