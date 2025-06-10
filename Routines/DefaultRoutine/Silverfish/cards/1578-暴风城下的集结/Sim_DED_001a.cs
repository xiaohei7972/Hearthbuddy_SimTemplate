using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_001a : SimTemplate //* 暗礁德鲁伊 DruidoftheReef
    {
        //<b>strike</b>
        //<b>冲锋</b>
        CardDB.Card Shark = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_001at);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, Shark);
        }

    }
}
