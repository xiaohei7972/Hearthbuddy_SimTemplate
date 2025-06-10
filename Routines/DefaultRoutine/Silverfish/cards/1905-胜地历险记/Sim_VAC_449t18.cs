using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Restore 6 Health to your hero.Destroy 2 random enemy minions.
	//<b>战吼：</b>为你的英雄恢复6点生命值。随机消灭2个敌方随从。
	class Sim_VAC_449t18 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 为己方英雄恢复6点生命值
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -6);

            // 随机消灭敌方随从的效果不实现
        }
    }
}
