using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Lesser Opal Spellstone
	//小型法术欧珀石
	//Draw 1 card.<i>(Attack with your hero@ |4(time, times) to upgrade.)</i>
	//抽一张牌。<i>（用你的英雄攻击@次后升级。）</i>
	class Sim_TOY_645 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }
    }
}
