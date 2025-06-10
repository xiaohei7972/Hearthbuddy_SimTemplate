using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_001b : SimTemplate //* 暗礁德鲁伊 DruidoftheReef
    {
        //<b>Taunt</b>
        //<b>嘲讽</b>
        CardDB.Card Turtle = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_001bt);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, Turtle);
        }

    }
}
