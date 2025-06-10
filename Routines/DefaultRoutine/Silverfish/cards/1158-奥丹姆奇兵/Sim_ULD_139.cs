using System;
using System.Collections.Generic;
using System.Text;
namespace HREngine.Bots
{
	class Sim_ULD_139 : SimTemplate //* 启迪者伊莉斯 Elise the Enlightened
//<b>Battlecry:</b> If your deck has no duplicates, duplicate your hand.
//<b>战吼：</b>如果你的牌库里没有相同的牌，则复制你的手牌。 
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.noDuplicates)
            {
                int ownCardsNum = p.owncards.Count;

                for (int i = 0; i < Math.Min(ownCardsNum, 10 - ownCardsNum); i++)
                {
                    p.drawACard(p.owncards[i].card.nameEN, own.own, true);
                }
            }
        }
	}
}