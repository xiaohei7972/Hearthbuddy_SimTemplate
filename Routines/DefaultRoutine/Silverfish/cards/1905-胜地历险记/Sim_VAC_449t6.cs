using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Deal 6 damageto the enemy hero.<b>Freeze</b> three random enemy minions.
	//<b>战吼：</b>对敌方英雄造成6点伤害。随机<b>冻结</b>三个敌方随从。
	class Sim_VAC_449t6 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 对敌方英雄造成6点伤害
            p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, 6);

            // 随机冻结敌方随从的效果不实现
        }
    }
}
