using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_SCH_514 : SimTemplate //* 亡者复生 Raise Dead
    {
        //Deal $3 damage to your hero. Return two friendly minions that died this game to your hand.
        //对你的英雄造成$3点伤害。将两个在本局对战中死亡的友方随从移回你的手牌。

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 对己方英雄造成3点伤害
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, 3);

            int rebornCard = 2; // 需要复活的随从数量
            List<CardDB.cardIDEnum> resurrectedMinions = new List<CardDB.cardIDEnum>();

            // 遍历己方墓地中的卡牌
            foreach (KeyValuePair<CardDB.cardIDEnum, int> e in p.ownGraveyard)
            {
                // 获取已死亡的随从卡牌
                CardDB.Card rebornMob = CardDB.Instance.getCardDataFromID(e.Key);

                // 如果不是随从类型，则跳过
                if (rebornMob.type != CardDB.cardtype.MOB) continue;

                // 将随从移回手牌，并计数
                for (int i = 0; i < e.Value && rebornCard > 0; i++)
                {
                    p.drawACard(e.Key, ownplay, true);
                    resurrectedMinions.Add(e.Key);
                    rebornCard--;
                }

                // 如果已经复活足够数量的随从，则退出循环
                if (rebornCard <= 0) break;
            }
        }
    }
}
