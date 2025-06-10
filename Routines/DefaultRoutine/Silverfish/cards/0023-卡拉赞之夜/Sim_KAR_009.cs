using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_009 : SimTemplate //* 呓语魔典 Babbling Book
//<b>Battlecry:</b> Add a random Mage spell to your hand.
//<b>战吼：</b>随机将一张法师法术牌置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.frostbolt, own.own, true);
		}
	}
}