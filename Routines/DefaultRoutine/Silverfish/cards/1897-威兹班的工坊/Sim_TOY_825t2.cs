using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Greater Spinel Spellstone
	//大型法术尖晶石
	//Give Undead in your hand +3/+3.
	//使你手牌中的亡灵获得+3/+3。
	class Sim_TOY_825t2 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 获取当前玩家的手牌列表
            List<Handmanager.Handcard> tempHand = ownplay ? p.owncards : p.enemyHand;

            // 遍历手牌中的卡牌
            foreach (Handmanager.Handcard hc in tempHand)
            {
                // 检查是否为亡灵随从
                if ((TAG_RACE)hc.card.race == TAG_RACE.UNDEAD)
                {
                    // 为亡灵随从增加 +3/+3
                    hc.addattack += 3;
                    hc.addHp += 3;
                }
            }
        }
    }
}
