using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Gorgonzormu
	//戈贡佐姆
	//[x]<b>Battlecry:</b> Get a 2-CostCheese that summonsthree 1-Cost minions.It upgrades each turn.
	//<b>战吼：</b>获取一张法力值消耗为（2）的奶酪。奶酪可以召唤三个法力值消耗为（1）的随从，且每回合都会升级。
	class Sim_VAC_955 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 获取一张法力值消耗为2的奶酪卡牌 (假设奶酪卡牌的ID为 VAC_955t)
            p.drawACard(CardDB.cardIDEnum.VAC_955t, own.own, true);
        }

    }
}
