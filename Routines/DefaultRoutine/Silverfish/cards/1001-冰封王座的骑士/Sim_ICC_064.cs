using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_064: SimTemplate //* 血刃剃刀 Blood Razor
//<b>Battlecry and Deathrattle:</b>Deal 1 damage to all_minions.
//[x]<b>战吼，亡语：</b>对所有随从造成1点伤害。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_064);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            p.allMinionsGetDamage(1);
            p.doDmgTriggers();
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(1);
            p.doDmgTriggers();
        }
    }
}