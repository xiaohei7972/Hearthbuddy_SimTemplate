
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TTN_800t : SimTemplate // 避免报错
    {
        // 在这里可以定义卡牌的属性，如法力值消耗、卡牌类型、效果等等
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damage = 3; // 伤害值
            int heal = 6;   // 治疗值

            // 如果是己方回合
            if (ownplay)
            {
                // 对敌方英雄和敌方随从造成伤害
                p.allMinionOfASideGetDamage(!ownplay, damage);

                // 对己方英雄和己方随从进行治疗
                p.allMinionOfASideGetDamage(ownplay, -heal);
            }
            else // 如果是对手回合
            {
                // 对我方英雄和我方随从造成伤害
                p.allMinionOfASideGetDamage(!ownplay, damage);

                // 对对手英雄和对手随从进行治疗
                p.allMinionOfASideGetDamage(ownplay, -heal);
            }
        }

        
        
    }
}
