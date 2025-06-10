using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258t3 : SimTemplate //* 火之祈咒 Invocation of Fire
//Deal 6 damage to the enemy hero.

//对敌方英雄造成6点伤害。 
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(6) : p.getEnemyHeroPowerDamage(6);
            p.minionGetDamageOrHeal(ownplay ? p.enemyHero : p.ownHero, dmg);
        }
    }
}