using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Restore 6 Health to your hero.Deal 2 damage to all enemy minions.
	//<b>战吼：</b>为你的英雄恢复6点生命值。对所有敌方随从造成2点伤害。
	class Sim_VAC_449t19 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 为己方英雄恢复6点生命值
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -6);

            // 对所有敌方随从造成2点伤害
            p.allMinionOfASideGetDamage(!own.own, 2);
        }
    }
}
