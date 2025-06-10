using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 中立 费用：8
    //Holy Book
    //神圣典籍
    //<b>Silence</b> and destroy a minion. Summon a 10/10 copy of it.
    //<b>沉默</b>并消灭一个随从。召唤一个它的10/10复制。
    class Sim_VAC_464t7 : SimTemplate
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetSilenced(target); // 沉默目标随从
                p.minionGetDestroyed(target); // 消灭目标随从

                // 召唤一个10/10的复制
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card copyCard = CardDB.Instance.getCardDataFromID(target.handcard.card.cardIDenum);
                p.callKid(copyCard, pos, ownplay, true); // 召唤复制
                Minion summonedCopy = ownplay ? p.ownMinions[p.ownMinions.Count - 1] : p.enemyMinions[p.enemyMinions.Count - 1];
                p.minionSetAngrToX(summonedCopy, 10);
                p.minionSetLifetoX(summonedCopy, 10);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }
    }
}
