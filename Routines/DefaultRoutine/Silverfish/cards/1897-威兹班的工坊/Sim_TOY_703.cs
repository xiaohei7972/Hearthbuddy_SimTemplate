using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：6 生命值：5
	//Colifero the Artist
	//美术家可丽菲罗
	//[x]<b>Battlecry:</b> Draw a minion.Transform all other friendlyminions into copies of it.
	//<b>战吼：</b>抽一张随从牌，将所有其他友方随从变形成为它的复制。
	class Sim_TOY_703 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 抽一张随从牌
            p.drawACard(CardDB.cardIDEnum.None, own.own);

            // 获取手牌的最后一张牌
            Handmanager.Handcard lastDrawnCard = p.owncards[p.owncards.Count - 1];

            // 如果最后抽到的牌是随从牌，将所有其他友方随从变形为它的复制
            if (lastDrawnCard != null && lastDrawnCard.card.type == CardDB.cardtype.MOB)
            {
                foreach (Minion minion in p.ownMinions.ToArray())
                {
                    if (minion.entitiyID != own.entitiyID)
                    {
                        p.minionTransform(minion, lastDrawnCard.card);
                    }
                }
            }
        }
    }
}
