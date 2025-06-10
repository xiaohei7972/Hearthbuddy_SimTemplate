using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Corpsicle
	//甜筒殡淇淋
	//Deal $3 damage. Spend 3 <b>Corpses</b> to return this to your handat the end of your turn.
	//造成$3点伤害。消耗3具<b>尸体</b>，在你的回合结束时将本牌移回你的手牌。
	class Sim_VAC_427 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);

            // 对目标造成3点伤害
            p.minionGetDamageOrHeal(target, dmg);

            // 获取己方的尸体数量并检查是否有足够的尸体
            if (ownplay && p.getCorpseCount() >= 3)
            {
                // 消耗3具尸体
                p.corpseConsumption(3);

                // 将卡牌标记为将在回合结束时返回手牌
                p.cardsToReturnAtEndOfTurn.Add(CardDB.cardIDEnum.VAC_427);
            }
        }

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 如果是当前玩家的回合结束，并且列表中包含该卡牌ID
            if (turnEndOfOwner && p.cardsToReturnAtEndOfTurn.Contains(CardDB.cardIDEnum.VAC_427))
            {
                // 将卡牌返回手牌
                p.drawACard(CardDB.cardIDEnum.VAC_427, m.own, true);

                // 移除返回标记
                p.cardsToReturnAtEndOfTurn.Remove(CardDB.cardIDEnum.VAC_427);
            }
        }
    }
}
