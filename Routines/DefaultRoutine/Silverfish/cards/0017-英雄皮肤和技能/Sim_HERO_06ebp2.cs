using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_06ebp2 : SimTemplate //* 恐怖变形 Dire Shapeshift
    {
        //<b>Hero Power</b>+2 Attack this turn.+2 Armor.
        //<b>英雄技能</b>本回合+2攻击力。+2护甲值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 2, 0);
                p.minionGetArmor(p.ownHero, 2);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 2, 0);
                p.minionGetArmor(p.enemyHero, 2);
            }
        }

    }
}
