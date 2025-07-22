using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_06ebp : SimTemplate //* 变形 Shapeshift
    {
        //<b>Hero Power</b>+1 Attack this turn.+1 Armor.
        //<b>英雄技能</b>本回合+1攻击力。+1护甲值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetTempBuff(p.ownHero, 1, 0);
                p.minionGetArmor(p.ownHero, 1);
            }
            else
            {
                p.minionGetTempBuff(p.enemyHero, 1, 0);
                p.minionGetArmor(p.enemyHero, 1);
            }
        }

    }
}
