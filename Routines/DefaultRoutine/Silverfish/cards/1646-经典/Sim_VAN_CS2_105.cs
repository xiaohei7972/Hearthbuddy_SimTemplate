using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 英勇打击 Heroic Strike/
    // /Give your hero +4_Attack this turn.
    //在本回合中，使你的英雄获得+4攻击力。
    class Sim_VAN_CS2_105 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            Minion hero = ownplay ? p.ownHero : p.enemyHero;
            p.minionGetTempBuff(hero, 4, 0);
            hero.updateReadyness();

        }

    }
}