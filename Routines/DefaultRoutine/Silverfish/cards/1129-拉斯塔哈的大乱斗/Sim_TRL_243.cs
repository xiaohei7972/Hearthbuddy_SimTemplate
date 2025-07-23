using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 飞扑 Pounce
    //Give your hero +2_Attack this turn.
    //在本回合中，使你的英雄获得+2攻击力。 
    class Sim_TRL_243 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            var hero = ownplay ? p.ownHero : p.enemyHero;
            p.minionGetTempBuff(hero, 2, 0);
            hero.updateReadyness();

        }

    }
}