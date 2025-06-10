using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：1 攻击力：3 生命值：1
	//Shadowbomber
	//暗影投弹手
	//<b>Battlecry:</b> Deal 3 damage to each hero.
	//<b>战吼：</b>对每个英雄造成3点伤害。
	class Sim_WON_062 : SimTemplate
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
