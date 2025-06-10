using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_033 : SimTemplate //* 钢铁触须 Tentacles for Arms
//<b>Deathrattle:</b> Return this to your hand.
//<b>亡语：</b>将这把武器移回你的手牌。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_033);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(p.ownWeapon.name, m.own, true);
        }
    }
}