using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_392 : SimTemplate //* 世界之树的嫩枝 Twig of the World Tree
//<b>Deathrattle:</b> Gain 10 Mana Crystals.
//<b>亡语：</b>获得十个法力水晶。
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_392);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.mana = 10;
                p.ownMaxMana = 10;
            }
            else
            {
                p.mana = 10;
                p.enemyMaxMana = 10;
            }
        }
    }
}
