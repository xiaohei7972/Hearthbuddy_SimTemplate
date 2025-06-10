using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：3
	//Mixologist
	//混调师
	//[x]<b>Battlecry:</b> Craft acustom 1-Cost Potion.
	//<b>战吼：</b>制造一张法力值消耗为（1）的自定义药水牌。
	class Sim_VAC_523 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 创建自定义药水牌
            CardDB.cardIDEnum customPotion = CardDB.cardIDEnum.VAC_523t; // 假设自定义药水的卡牌ID为 VAC_523t
            p.drawACard(customPotion, own.own, true); // 将药水牌加入手牌
        }
    }
}
