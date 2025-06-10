using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：1
	//Sweetened Snowflurry
	//甜蜜雪灵
	//[x]<b>Mini</b><b>Battlecry:</b> Get 2 random<b>Temporary</b> Frost spells.
	//<b>微型</b><b>战吼：</b>随机获取2张<b>临时</b>冰霜法术牌。
	class Sim_TOY_307t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 随机获取2张临时的冰霜法术牌
            for (int i = 0; i < 2; i++)
            {
                p.drawTemporaryCard(CardDB.cardIDEnum.None, own.own);
            }
        }

    }
}
