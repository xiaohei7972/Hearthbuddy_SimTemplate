using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：1 生命值：4
	//Origami Frog
	//折纸青蛙
	//[x]<b>Rush</b><b>Battlecry:</b> Swap Attackwith another minion.
	//<b>突袭</b>。<b>战吼：</b>与另一个随从交换攻击力。
	class Sim_TOY_894 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 确保目标随从有效
            if (target != null)
            {
                // 交换攻击力
                int tempAttack = own.Angr;
                own.Angr = target.Angr;
                target.Angr = tempAttack;

                // 确保攻击力不低于1
                if (own.Angr < 0) own.Angr = 0;
                if (target.Angr < 0) target.Angr = 0;
            }
        }


    }
}
