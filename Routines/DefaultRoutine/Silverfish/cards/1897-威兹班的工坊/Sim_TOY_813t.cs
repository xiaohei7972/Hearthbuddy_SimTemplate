using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：1 攻击力：1 生命值：1
	//Toy Captain Tarim
	//玩具队长塔林姆
	//[x]<b>Mini</b><b>Taunt</b>. <b>Battlecry:</b> Set aminion's Attack and Healthto this minion's.
	//<b>微型</b><b>嘲讽</b>。<b>战吼：</b>将一个随从的攻击力和生命值变为与本随从相同。
	class Sim_TOY_813t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 执行战吼效果，将目标随从的攻击力和生命值设置为与本随从相同
            if (target != null)
            {
                p.minionSetAngrToX(target, own.Angr);
                p.minionSetLifetoX(target, own.Hp);
            }
        }

    }
}
