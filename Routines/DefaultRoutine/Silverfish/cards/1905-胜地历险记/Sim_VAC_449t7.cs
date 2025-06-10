using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//[x]<b>Battlecry:</b> Deal 6 damageto the enemy hero.Gain +2/+2 and <b>Taunt</b>.
	//<b>战吼：</b>对敌方英雄造成6点伤害。获得+2/+2和<b>嘲讽</b>。
	class Sim_VAC_449t7 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 对敌方英雄造成6点伤害
            p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, 6);

            // 增加+2/+2
            p.minionGetBuffed(own, 2, 2);

            // 赋予嘲讽
            own.taunt = true;
        }
    }
}
