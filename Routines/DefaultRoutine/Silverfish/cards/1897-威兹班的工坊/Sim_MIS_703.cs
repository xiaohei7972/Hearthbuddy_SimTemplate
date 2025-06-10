using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：4 攻击力：6 生命值：6
	//INFERNAL!
	//地狱火！
	//[x]<b>Taunt</b><b>Battlecry:</b> Set your hero'sremaining Health to 15.
	//<b>嘲讽</b>。<b>战吼：</b>将你的英雄的剩余生命值变为15。
	class Sim_MIS_703 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 处理战吼效果：将己方英雄的剩余生命值设置为15
            Minion hero = own.own ? p.ownHero : p.enemyHero;

            int currentHealth = hero.Hp;

            if (currentHealth > 15)
            {
                // 如果当前生命值大于15，减少生命值到15
                hero.Hp = 15;
            }
            else if (currentHealth < 15)
            {
                // 如果当前生命值小于15，增加生命值到15
                hero.Hp = 15;
            }
        }
    }
}
