using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：3 攻击力：2 生命值：3
    //Coldlight Seer
    //寒光先知
    //<b>Battlecry:</b> Give your other Murlocs +2 Health.
    //<b>战吼：</b>使你的其他鱼人获得+2生命值。
    class Sim_BG_EX1_103 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.ownMinons)
            {
                if(m.handcard.card.Race == 14){
                    m.minionGetBuffed(m, 1, 0);
                }

            }
        }



    }
}
