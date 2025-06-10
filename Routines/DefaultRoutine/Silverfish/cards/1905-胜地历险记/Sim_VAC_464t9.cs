using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：3
	//Looming Presence
	//浮光掠影
	//Draw 2 cards. Gain 4 Armor.
	//抽两张牌。获得4点护甲值。
	class Sim_VAC_464t9 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay); // 抽第一张牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay); // 抽第二张牌
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 4); // 获得4点护甲值
        }
    }
}
