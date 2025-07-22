using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_314t1 : SimTemplate //* 霜之哀伤 Frostmourne
//<b>Deathrattle:</b> Summon every minion killed by this weapon.
//<b>亡语：</b>召唤被该武器消灭的所有随从。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_314t1);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_110t), m.zonepos - 1, m.own);
        }
    }
}