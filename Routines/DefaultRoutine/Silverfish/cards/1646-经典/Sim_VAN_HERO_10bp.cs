using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_HERO_10bp : SimTemplate //* 恶魔之爪 Demon's Bite
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //[x]<b>Hero Power</b>+2 Attack this turn.
            //<b>英雄技能</b>在本回合中获得+1攻击力。
            var hero = ownplay ? p.ownHero : p.enemyHero;
            p.minionGetTempBuff(hero, 1, 0);
            hero.updateReadyness();
        }
    }
}