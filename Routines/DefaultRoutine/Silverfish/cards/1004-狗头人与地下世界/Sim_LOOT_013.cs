using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_013 : SimTemplate //* 粗俗的矮劣魔 Vulgar Homunculus
//<b>Taunt</b><b>Battlecry:</b> Deal 2 damage to your hero.
//<b>嘲讽，战吼：</b>对你的英雄造成2点伤害。 
    {

        
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 2);
        }


    }
}