using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ETC_075 : SimTemplate //* 闭麦收工 Mic Drop
                                    //抽两张牌。&lt;b&gt;压轴：&lt;/b&gt;使你的武器获得+2攻击力。
                                    //Draw 2 cards.&lt;b&gt;Finale:&lt;/b&gt; Give your weapon +2 Attack.
    {
        // 处理使用法术效果的方法
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 记录使用法术前的法力值
            int beforeMana = ownplay ? p.mana : p.enemyMaxMana;

            // 抽两张牌
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);

            // 如果有武器，且压轴效果满足（剩余法力值与使用法术前相同），使其获得+2攻击力
            if (p.ownWeapon.Durability > 0 && 3 == beforeMana)
            {
                p.ownWeapon.Angr += 2;
            }
        }

    }
}
