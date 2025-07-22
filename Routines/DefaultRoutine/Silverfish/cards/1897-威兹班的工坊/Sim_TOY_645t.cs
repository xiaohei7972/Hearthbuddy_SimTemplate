using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Opal Spellstone
	//法术欧珀石
	//Draw 2 cards.<i>(Attack with your hero@ |4(time, times) to upgrade.)</i>
	//抽两张牌。<i>（用你的英雄攻击@次后升级。）</i>
	class Sim_TOY_645t : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽二张牌
            for (int i = 0; i < 2; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }
    }
}
