
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ETC_717t : SimTemplate //* 刺耳嘻哈 Dissonant Hip Hop
                                    //造成3点伤害。使你的武器获得+1攻击力。&lt;i&gt;（每回合切换。）&lt;/i&gt;
                                    //Deal 3 damage. Give your weapon +1 Attack.&lt;i&gt;(Swaps each turn.)&lt;/i&gt;
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 如果目标存在
            if (target != null)
            {
                // 根据是否为己方回合计算伤害值
                int dmg = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

                // 对目标造成伤害
                p.minionGetDamageOrHeal(target, dmg);

                // 如果己方武器存在，增加武器的攻击力
                if (p.ownWeapon.Durability > 0)
                {
                    p.minionGetBuffed(p.ownHero, 1, 0); // 给英雄增加1点攻击力，以反映武器的增加
                    p.ownWeapon.Angr += 1; // 增加武器攻击力
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
            new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
            new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET), // 目标必须是非自身
        };
        }
    }


}
        