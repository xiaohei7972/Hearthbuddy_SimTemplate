using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_056 : SimTemplate //* 钢铁战蝎 Iron Juggernaut
//<b>Battlecry:</b> Shuffle a Mine into your opponent's deck. When drawn, it explodes for 10 damage.
//<b>战吼：</b>将一张“地雷” 牌洗入你对手的牌库。当玩家抽到“地雷”时，便会受到10点伤害。 
    {

        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.enemyDeckSize++;
                if (p.enemyDeckSize <= 6)
                {
                    p.minionGetDamageOrHeal(p.enemyHero, Math.Min(10, p.enemyHero.Hp-1), true);
                    p.evaluatePenality -= 6;
                }
                else
                {
                    if (p.enemyDeckSize <= 16)
                    {
                        p.minionGetDamageOrHeal(p.enemyHero, Math.Min(5, p.enemyHero.Hp - 1), true);
                        p.evaluatePenality -= 8;
                    }
                    else
                    {
                        if (p.enemyDeckSize <= 26)
                        {
                            p.minionGetDamageOrHeal(p.enemyHero, Math.Min(2, p.enemyHero.Hp - 1), true);
                            p.evaluatePenality -= 10;
                        }
                    }
                }
            }
            else
            {
                p.ownDeckSize++;
            }
        }


    }

}