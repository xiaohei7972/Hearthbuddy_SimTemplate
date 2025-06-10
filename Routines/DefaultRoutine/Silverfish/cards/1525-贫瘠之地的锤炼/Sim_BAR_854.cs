using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：1 攻击力：1 生命值：2
	//Kindling Elemental
	//火光元素
	//[x]<b>Battlecry:</b> The next Elemental you playcosts (1) less.
	//<b>战吼：</b>你的下一张元素牌的法力值消耗减少（1）点。
	class Sim_BAR_854 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 增加下一张元素牌的法力值消耗减少量
            if (own.own)
            {
                p.nextElementalReduction += 1;
            }
        }
    }
}
