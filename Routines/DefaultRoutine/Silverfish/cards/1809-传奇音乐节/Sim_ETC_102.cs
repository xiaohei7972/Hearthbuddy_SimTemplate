using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：1 攻击力：1 生命值：1
    //Air Guitarist
    //空气吉他手
    //<b>Battlecry:</b> Give your weapon +1 Durability.
    //<b>战吼：</b>使你的武器获得+1耐久度。
    class Sim_ETC_102 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                // 如果是玩家的随从，增加玩家武器的耐久度
                p.ownWeapon.Durability++;
            }
            else
            {
                // 如果是敌人的随从，增加敌人武器的耐久度
                p.enemyWeapon.Durability++;
            }
        }
    }
}
