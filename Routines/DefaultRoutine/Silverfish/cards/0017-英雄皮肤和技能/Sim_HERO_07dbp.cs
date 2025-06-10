using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_HERO_07dbp : SimTemplate //* 生命分流 Life Tap
    {
        //<b>Hero Power</b>Draw a card and take $2_damage.
        //<b>英雄技能</b>抽一张牌并受到$2点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            int dmg = 2;
            if (ownplay)
            {
                if (p.doublepriest >= 1) dmg *= (2 * p.doublepriest);
                p.minionGetDamageOrHeal(p.ownHero, dmg);
            }
            else
            {
                if (p.enemydoublepriest >= 1) dmg *= (2 * p.enemydoublepriest);
                p.minionGetDamageOrHeal(p.enemyHero, dmg);
            }
        }

    }
}
