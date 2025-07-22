using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_304 : SimTemplate //* 法拉基战斧 Farraki Battleaxe
//<b>Overkill:</b> Give a minion in your hand +2/+2.
//<b>超杀：</b>使你手牌中的一张随从牌获得+2/+2。 
	{
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_304);



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(card,ownplay);
		}
	}
}