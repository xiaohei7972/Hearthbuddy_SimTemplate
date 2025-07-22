using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Gain +2/+2and <b>Taunt</b>.Restore 6 Health to your hero.
	//<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。为你的英雄恢复6点生命值。
	class Sim_VAC_449t15 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 增加+2/+2
            p.minionGetBuffed(own, 2, 2);

            // 赋予嘲讽
            own.taunt = true;

            // 为己方英雄恢复6点生命值
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -6);
        }

    }
}
