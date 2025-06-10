using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_WW_424 : SimTemplate // Overflowing Lava
    {
        // <b>战吼：</b> 每有一个你使用过元素牌的连续的回合，召唤一个本随从的复制。<i>（召唤@个）</i>
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int consecutiveElementalTurns = Hrtprozis.Instance.ownConsecutiveElementalTurns; // 获取玩家连续使用元素牌的回合数
            for (int i = 0; i < consecutiveElementalTurns; i++)
            {
                p.callKid(m.handcard.card, m.zonepos, m.own); // 在指定位置召唤一个随从的复制
            }
        }
    }
}
