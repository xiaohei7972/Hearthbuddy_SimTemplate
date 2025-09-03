using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 迅猛龙之灵 Spirit of the Raptor
    //[x]<b>Stealth</b> for 1 turn.After your hero attacks and__kills a minion, draw a card.__
    //<b>潜行</b>一回合。在你的英雄攻击并消灭一个随从后，抽一张牌。 
    class Sim_TRL_223 : SimTemplate
    {
        public override void afterHeroattack(Playfield p, Minion triggerMinion, Minion target, Minion hero)
        {
            if (triggerMinion.own == hero.own)
            {
                if (target != null)
                {
                    if (target.Hp < 1)
                        p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own);
                }
            }
        }
    }
}