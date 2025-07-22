using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_074 : SimTemplate //* 锯刃齿 Serrated Tooth
//<b>Deathrattle:</b> Give your minions <b>Rush</b>.
//<b>亡语：</b>使你的所有随从获得<b>突袭</b>。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_074);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m != null) p.minionGetRush(m);
        }
    }
}