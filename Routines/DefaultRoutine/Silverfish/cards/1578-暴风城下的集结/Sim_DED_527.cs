using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_527 : SimTemplate //* 操纵火炮 Man the Cannons
    {
        //可交易在你交易此牌后，获得+2耐久度。
        //Tradeable After you Trade this, gain +2 Durability.
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_527);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(wcard, ownplay);
        }
    }
}
