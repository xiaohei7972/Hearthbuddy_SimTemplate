using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 德鲁伊 费用：3
    //Overgrown Beanstalk
    //豆蔓疯长
    //Summon a 2/2 Treant. Draw a card for each Treant you control.
    //召唤一个2/2的树人。你每控制一个树人，抽一张牌。
    class Sim_MIS_301 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.MIS_301t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
            // 召唤一个2/2的树人
            p.callKid(kid, pos, ownplay);

            // 计算己方控制的树人数量
            foreach (Minion m in minions)
            {
                if (m.handcard.card.Treant) // 假设树人的名称为 treant
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay);
                }
            }

        }
    }
}
