using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 虫群德鲁伊 Druid of the Swarm
    //<b>Choose One -</b> Transform into a 1/2 with <b>Poisonous</b>; or a 1/5 with <b>Taunt</b>.
    //<b>抉择：</b>将该随从变形成为1/2并具有<b>剧毒</b>；或者将该随从变形成为1/5并具有<b>嘲讽</b>。 

    class Sim_ICC_051 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_051t);
        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_051t2);
        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_051t3);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.ownFandralStaghelm > 0)
            {
                p.minionTransform(own, kid2);
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, kid);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, kid1);
                }
            }

        }
    }
}