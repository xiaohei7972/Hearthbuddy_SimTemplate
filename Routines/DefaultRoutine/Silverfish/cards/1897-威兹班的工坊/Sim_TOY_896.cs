using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：6 攻击力：1 生命值：1
	//Origami Dragon
	//折纸巨龙
	//[x]<b>Divine Shield</b>, <b>Lifesteal</b><b>Battlecry:</b> Swap statswith another minion.
	//<b>圣盾</b>，<b>吸血</b><b>战吼：</b>与另一个随从交换属性值。
	class Sim_TOY_896 : SimTemplate
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

                // 交换生命值
                int tempHealth = own.Hp;
                own.Hp = target.Hp;
                target.Hp = tempHealth;

                // 交换最大生命值
                int tempMaxHp = own.maxHp;
                own.maxHp = target.maxHp;
                target.maxHp = tempMaxHp;

                // 确保生命值和攻击力合法性
                if (own.Hp < 1) own.Hp = 1;
                if (target.Hp < 1) target.Hp = 1;
                if (own.Angr < 0) own.Angr = 0;
                if (target.Angr < 0) target.Angr = 0;
            }
        }

    }
}
