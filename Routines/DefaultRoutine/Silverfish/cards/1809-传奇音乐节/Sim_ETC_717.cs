
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ETC_717 : SimTemplate //* 悦耳嘻哈 Harmonic Hip Hop
                                    //造成1点伤害。使你的武器获得+3攻击力。&lt;i&gt;（每回合切换。）&lt;/i&gt;
                                    //Deal 1 damage. Give your weapon +3 Attack.&lt;i&gt;(Swaps each turn.)&lt;/i&gt;
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 如果目标存在
            if (target != null)
            {
                // 根据是否为自己的回合决定伤害值
                int dmg = ownplay ? p.getSpellDamageDamage(1) : p.getEnemySpellDamageDamage(1);

                // 对目标造成伤害
                p.minionGetDamageOrHeal(target, dmg);

                // 如果我方武器存在，增加武器攻击力
                if (p.ownWeapon.Durability > 0)
                {
                    p.minionGetBuffed(p.ownHero, 3, 0); // 给英雄增加3点攻击力
                    p.ownWeapon.Angr += 3; // 增加武器攻击力
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
        