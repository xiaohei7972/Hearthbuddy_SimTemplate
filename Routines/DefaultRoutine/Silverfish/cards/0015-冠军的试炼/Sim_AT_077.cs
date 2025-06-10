using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_077 : SimTemplate //* 白银之枪 Argent Lance
//<b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, +1 Durability.
//<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，+1耐久度。 
	{
		

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_077);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }
	}
}