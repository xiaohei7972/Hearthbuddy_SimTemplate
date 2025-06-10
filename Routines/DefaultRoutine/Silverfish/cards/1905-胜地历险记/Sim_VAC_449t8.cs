using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Deal 6 damageto the enemy hero.Restore 6 Health to your hero.
	//<b>战吼：</b>对敌方英雄造成6点伤害。为你的英雄恢复6点生命值。
	class Sim_VAC_449t8 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 对敌方英雄造成6点伤害
            p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, 6);

            // 为己方英雄恢复6点生命值
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -6);
        }
    }
}
