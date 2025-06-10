using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：3 生命值：4
	//Blasteroid
	//爆炎流星
	//<b>Battlecry:</b> Shuffle 5 random Fire spells into your deck. They cost (2) less.
	//<b>战吼：</b>随机将5张火焰法术牌洗入你的牌库，其法力值消耗减少（2）点。
	class Sim_GDB_303 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) p.ownDeckSize += 5; // 自己的牌库大小增加
            else p.enemyDeckSize += 5; // 敌人的牌库大小增加
		}
		
	}
}
