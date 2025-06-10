using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_009 : SimTemplate //* 暗影投弹手 Shadowbomber
//<b>Battlecry:</b> Deal 3 damage to each hero.
//<b>战吼：</b>对每个英雄造成3点伤害。 
    {

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int damage = 3;

            // 对己方英雄造成3点伤害
            p.minionGetDamageOrHeal(p.ownHero, damage);

            // 对敌方英雄造成3点伤害，并更新本回合对敌方英雄造成的伤害
            p.minionGetDamageOrHeal(p.enemyHero, damage);
        }


    }

}