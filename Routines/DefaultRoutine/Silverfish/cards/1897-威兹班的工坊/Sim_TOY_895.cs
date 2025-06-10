using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：4 生命值：1
	//Origami Crane
	//折纸仙鹤
	//[x]<b>Taunt</b><b>Battlecry:</b> Swap Healthwith another minion.
	//<b>嘲讽</b>。<b>战吼：</b>与另一个随从交换生命值。
	class Sim_TOY_895 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 确保目标随从有效
            if (target != null)
            {
                // 交换生命值
                int tempHealth = own.Hp;
                own.Hp = target.Hp;
                target.Hp = tempHealth;

                // 调整最大生命值
                own.maxHp = own.Hp;
                target.maxHp = target.Hp;

                // 确保生命值不低于1
                if (own.Hp < 1) own.Hp = 1;
                if (target.Hp < 1) target.Hp = 1;
            }
        }


    }
}
