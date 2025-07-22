using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：4
	//Ancient Reflections
	//远古映像
	//Choose a minion.Fill your board with 1/1 copies of it.
	//选择一个随从。用它的1/1的复制填满你的面板。
	class Sim_VAC_464t19 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target == null) return;

            int maxMinions = 7;
            int availableSlots = ownplay ? maxMinions - p.ownMinions.Count : maxMinions - p.enemyMinions.Count;

            for (int i = 0; i < availableSlots; i++)
            {
                CardDB.Card copyCard = CardDB.Instance.getCardDataFromID(target.handcard.card.cardIDenum);
                p.callKid(copyCard, p.ownMinions.Count, ownplay);
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
