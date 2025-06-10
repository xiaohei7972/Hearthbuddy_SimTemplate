using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_193 : SimTemplate //* 心灵咒术师 Psychic Conjurer
	{
		//<b>Battlecry:</b> Copy a card in your opponent’s deck and add it to your hand.
		//<b>战吼：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

                p.drawACard(CardDB.cardIDEnum.None, ownplay,true);
        }		
		
	}
}
