using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：3 攻击力：2 生命值：4
	//Snuggle Teddy
	//抱抱泰迪熊
	//<b>Gigantify</b><b>Elusive</b>, <b>Lifesteal</b>, <b>Taunt</b>
	//<b>扩大</b><b>扰魔</b>，<b>吸血</b>，<b>嘲讽</b>
	class Sim_MIS_300 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 扩大效果：抽一张衍生物牌
            CardDB.cardIDEnum gigantifyCardID = CardDB.cardIDEnum.MIS_300t; // 假设衍生物牌的 ID 是 MIS_300t
            p.drawACard(gigantifyCardID, ownplay, true);
        }
    }
}
