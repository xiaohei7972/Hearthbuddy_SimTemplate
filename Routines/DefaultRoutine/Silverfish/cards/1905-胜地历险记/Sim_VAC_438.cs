using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Travel Agent
	//旅行社职员
	//<b>Battlecry: Discover</b> a location from any class.
	//<b>战吼：发现</b>一张任意职业的地标牌。
	class Sim_VAC_438 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 简单实现：抽取一张随机牌，模拟“发现”效果
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}
