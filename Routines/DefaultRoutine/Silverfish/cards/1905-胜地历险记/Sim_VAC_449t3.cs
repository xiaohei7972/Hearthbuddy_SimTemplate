using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Draw 2 cards.Restore 6 Health toyour hero.
	//<b>战吼：</b>抽两张牌。为你的英雄恢复6点生命值。
	class Sim_VAC_449t3 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 抽两张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            p.drawACard(CardDB.cardIDEnum.None, own.own);

            // 为己方英雄恢复6点生命值
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, -6);
        }
    }
}
