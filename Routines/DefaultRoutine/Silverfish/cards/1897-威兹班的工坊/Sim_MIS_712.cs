using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：6 攻击力：7 生命值：7
	//Toyrantus
	//模玩泰拉图斯
	//<b>Taunt</b>, <b>Elusive</b><b>Battlecry:</b> If you have10 Mana Crystals,gain +7/+7.
	//<b>嘲讽</b>，<b>扰魔</b><b>战吼：</b>如果你有十个法力水晶，获得+7/+7。
	class Sim_MIS_712 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 检查是否有十个法力水晶
            if (p.ownMaxMana >= 10)
            {
                // 如果有十个法力水晶，随从获得+7/+7
                p.minionGetBuffed(own, 7, 7);
            }
        }
    }
}
