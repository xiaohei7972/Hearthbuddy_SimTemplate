using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_127  : SimTemplate// BT_127  被禁锢的萨特
//休眠两回合。唤醒时，使你手牌中的随机一张随从牌的法力值消耗减少（5）点。

	{
        public override void onDormantEndsTrigger(Playfield p, Minion m)
        {
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    hc.manacost = Math.Max(0, hc.manacost - 5);
                }
            }
        }
    }
}