using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_921 : SimTemplate //* 奥达奇战刃 Aldrachi Warblades
	{
		//<b>Lifesteal</b>
		//<b>吸血</b>
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_921);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(card,ownplay);
		}		
		
	}
}
