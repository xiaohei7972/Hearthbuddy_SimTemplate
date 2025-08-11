using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 深铁穴居人 irondeeptrogg
    //在你的对手施放一个法术后，召唤一个该随从的复制。
    class Sim_AV_137 : SimTemplate
    {
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_137);
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion m)
        {
            if (m.own != wasOwnCard && hc.card.type == CardDB.cardtype.SPELL)
            {
                p.callKid(kid, m.zonepos, m.own);
            }
            //     Playfield tmep = new Playfield(p);
            //     bool findm = false;
            //     hc.card.sim_card.onCardPlay(tmep, wasOwnCard, hc.target, 0);//test
            //     int mpos = 0;
            //     foreach (Minion temp in tmep.enemyMinions)
            //     {
            //         if (temp.entitiyID == m.entitiyID)
            //         {
            //             if (temp.Hp > 0)
            //                 findm = true;
            //             mpos = temp.zonepos;
            //             break;
            //         }

            //     }
            //     if (findm)
            //     {

            //         if (hc.card.type == CardDB.cardtype.SPELL && wasOwnCard == true)
            //         {
            //             if (p.enemyMinions.Count < 7)
            //             {
            //                 p.callKid(kid, m.zonepos, !m.own);
            //             }
            //         }
            //     }
        }
    }

}

