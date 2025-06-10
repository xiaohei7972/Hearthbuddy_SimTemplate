using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：5
	//The Replicator-inator
	//复制鬼才
	//[x]<b>Miniaturize</b>, <b>Gigantify</b>After you play a minion withthe same Attack as this,summon a copy of it.
	//<b>微缩</b>，<b>扩大</b>在你使用一张攻击力与本随从相同的随从牌后，召唤一个它的复制。
	class Sim_MIS_025 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理“微缩”效果，抽一张微缩衍生物牌
            CardDB.cardIDEnum miniaturizeCardID = CardDB.cardIDEnum.MIS_025t; // 假设“微缩”衍生物牌的 ID 是 MIS_025t
            p.drawACard(miniaturizeCardID, ownplay, true);

            // 处理“扩大”效果，抽一张扩大衍生物牌
            CardDB.cardIDEnum gigantifyCardID = CardDB.cardIDEnum.MIS_025t1; // 假设“扩大”衍生物牌的 ID 是 MIS_025t1
            p.drawACard(gigantifyCardID, ownplay, true);
        }

        public override void onCardWasPlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 只在己方随从卡牌被打出后触发效果
            if (wasOwnCard && c.type == CardDB.cardtype.MOB)
            {
                // 检查触发效果的随从是否为“复制鬼才”
                if (triggerEffectMinion != null && triggerEffectMinion.name == CardDB.cardNameEN.thereplicatorinator)
                {
                    // 检查打出的随从攻击力是否与“复制鬼才”相同
                    if (c.Attack == triggerEffectMinion.Angr)
                    {
                        // 召唤一个它的复制
                        p.callKid(c, triggerEffectMinion.zonepos, true);
                    }
                }
            }
        }
    }
}
