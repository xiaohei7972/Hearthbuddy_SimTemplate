using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_938t : SimTemplate //* 暗影之门 Door of Shadows
//已注能抽一张法术牌，并将它的一张临时复制置入你的手牌。
//Infused Draw a spell.Add a temporary copy of it to your hand.
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽一张法术牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            // 获取最后抽到的卡牌
            Handmanager.Handcard lastDrawnCard = p.owncards[p.owncards.Count - 1];

            // 检查抽到的是否为法术牌
            if (lastDrawnCard.card.type == CardDB.cardtype.SPELL)
            {
                // 将该法术牌的临时复制添加到手牌
                p.drawACard(lastDrawnCard.card.cardIDenum, ownplay, true);
            }
        }
    }
}
