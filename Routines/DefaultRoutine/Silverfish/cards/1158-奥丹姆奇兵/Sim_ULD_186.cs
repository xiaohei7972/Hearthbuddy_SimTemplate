using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_186 : SimTemplate //* 法老御猫 Pharaoh Cat
//<b>Battlecry:</b> Add a random <b>Reborn</b> minion to your_hand.
//<b>战吼：</b>随机将一张<b>复生</b>随从牌置入你的手牌。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, own.own);
		}


	}
}