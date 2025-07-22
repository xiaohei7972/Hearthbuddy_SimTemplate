using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：2 攻击力：3 生命值：2
	//Shambling Zombietank
	//蹒跚的僵尸坦克
	//[x]<b>Taunt</b><b>Battlecry:</b> Spend 5 <b>Corpses</b>to summon a copy of this.
	//<b>嘲讽</b>。<b>战吼：</b>消耗5具<b>尸体</b>以召唤一个本随从的复制。
	class Sim_TOY_827 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 检查是否有足够的尸体数量
            if (p.getCorpseCount() >= 5)
            {
                // 消耗5具尸体
                p.corpseConsumption(5);

                // 召唤一个该随从的复制
                p.callKid(own.handcard.card, own.zonepos, own.own);
            }
        }

    }
}
