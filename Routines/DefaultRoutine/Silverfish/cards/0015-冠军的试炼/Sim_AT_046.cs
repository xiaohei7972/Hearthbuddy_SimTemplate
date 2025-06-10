using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_046 : SimTemplate //* 海象人图腾师 Tuskarr Totemic
//<b>Battlecry:</b> Summon a random basic Totem.
//<b>战吼：</b>随机召唤一个基础图腾。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_050);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos, own.own);
        }
    }
}