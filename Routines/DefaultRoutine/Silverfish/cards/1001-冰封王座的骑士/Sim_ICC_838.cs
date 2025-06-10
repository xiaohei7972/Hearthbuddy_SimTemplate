using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_838 : SimTemplate //* 辛达苟萨 Sindragosa
//<b>Battlecry:</b> Summon two 0/1 Frozen Champions.
//<b>战吼：</b>召唤两个0/1的被冰封的勇士。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_838t); 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos - 1, own.own); 
            p.callKid(kid, own.zonepos, own.own);
        }
    }
}