using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：4 攻击力：3 生命值：4
	//Turbulus
	//湍流元素特布勒斯
	//<b>Hunter Tourist</b>. <b>Battlecry:</b> Give +1/+1 to all other <b>Battlecry</b> minions in your hand, deck, and battlefield.
	//<b>猎人游客</b><b>战吼：</b>使你手牌，牌库和战场上的所有其他<b>战吼</b>随从获得+1/+1。
	class Sim_WORK_013 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.minionGetBuffed(own, 1, 1);
		}
		
	}
}
