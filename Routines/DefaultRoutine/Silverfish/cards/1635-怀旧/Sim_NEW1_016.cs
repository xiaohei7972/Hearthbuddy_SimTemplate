using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_016 : SimTemplate //* 船长的鹦鹉 Captain's Parrot
//<b>Battlecry:</b> Draw a Pirate from your deck.
//<b>战吼：</b>从你的牌库中抽一张海盗牌。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, true, true);
		}


	}
}