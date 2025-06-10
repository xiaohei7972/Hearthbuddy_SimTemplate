
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ETC_312 : SimTemplate //* 爱豆的爱 Idol's Adoration
                                    //你的英雄技能法力值消耗为（0）点。在你使用技能后，失去1点耐久度。
                                    //Your Hero Power costs (0). After you use it, lose 1 Durability.
     {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 将下一个英雄技能的法力值消耗设置为0
            p.ownHeroPowerCostLessTwice = 0;
        }
    }
}
        