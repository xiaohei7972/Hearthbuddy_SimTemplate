using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：1 攻击力：2 生命值：1
	//Spacerock Collector
	//星岩收藏家
	//<b>Battlecry:</b> Your next <b>Combo</b> card costs (1) less.
	//<b>战吼：</b>你的下一张<b>连击</b>牌法力值消耗减少（1）点。
	class Sim_GDB_875 : SimTemplate
	{
		/// <summary>
        /// 在卡牌打出时触发
        /// </summary>
       	public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)  // 如果是己方打出此卡
            {
                // 遍历玩家手牌
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.Combo)  // 如果找到一张连击牌
                    {
                        // 将该牌费用减1，但不低于0
                        hc.manacost = Math.Max(0, hc.manacost - 1);
                        break;  // 只对找到的第一张连击牌生效，然后退出循环
                    }
                }
            }
        }
		
	}
}
