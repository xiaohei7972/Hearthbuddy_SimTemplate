
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_CORE_UNG_809 : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.UNG_809t1, own.own, true);
        }
    }
}
