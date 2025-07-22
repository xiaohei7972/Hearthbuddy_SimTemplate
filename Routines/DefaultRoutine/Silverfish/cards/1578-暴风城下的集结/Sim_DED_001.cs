using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_001 : SimTemplate //* 暗礁德鲁伊 DruidoftheReef
    {
        //抉择：将该随从变形成为3/1并具有突袭的鲨鱼；或者将该随从变形成为1/3并具有嘲讽的海龟。
        //Choose One - Transform into a 3/1 Shark with Rush; or a 1/3 Turtle with Taunt.
        CardDB.Card Shark = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_001a);
        CardDB.Card Turtle = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_001b);
        CardDB.Card SharkTurtle = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_001c);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.ownFandralStaghelm > 0)
            {
                p.minionTransform(own, SharkTurtle);
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, Shark);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, Turtle);
                }
            }
        }

    }
}
