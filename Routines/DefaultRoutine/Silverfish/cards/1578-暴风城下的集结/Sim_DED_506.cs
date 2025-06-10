using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_506 : SimTemplate //* 贪婪需求 NeedforGreede
    {
        //可交易抽三张牌。如果该牌在本回合被抽到，则法力值消耗为（3）点。
        //Tradeable Draw 3 cards. If drawn this turn, this costs (3).
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //current
            //foreach (Handmanager.Handcard ohc in p.owncards)
            //{
            //    if (ohc.card.nameCN == CardDB.cardNameCN.贪婪需求 && m.handcard.poweredUp)
            //    {
            //        ohc.manacost = 3;
            //    }
            //    else if (ohc.card.nameCN == CardDB.cardNameCN.贪婪需求 && !m.handcard.poweredUp)
            //    {
            //        ohc.manacost = 5;
            //    }
            //}
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

        //public override void onAuraStarts(Playfield p, Minion own)
        //{
        //    foreach (Handmanager.Handcard ohc in p.owncards)
        //    {
        //        if (ohc.card.nameCN == CardDB.cardNameCN.贪婪需求 && tag == 0)
        //        ohc.manacost = 3;
        //    }
        //}

        //public override void onAuraEnds(Playfield p, Minion m)
        //{
        //    foreach (Handmanager.Handcard ohc in p.owncards)
        //    {
        //        if (ohc.card.nameCN == CardDB.cardNameCN.贪婪需求)
        //        {
        //            ohc.manacost = 5;
        //            tag = 1;
        //        }
        //    }
        //}

    }
}
