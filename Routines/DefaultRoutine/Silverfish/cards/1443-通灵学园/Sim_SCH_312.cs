using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_SCH_312 : SimTemplate // Tour Guide
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 将下一个英雄技能的法力值消耗设置为0
            p.ownHeroPowerCostLessOnce = 0;
        }
    }
}
