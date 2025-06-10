using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_026: SimTemplate //* 冷酷的死灵法师 Grim Necromancer
//<b>Battlecry:</b> Summon two 1/1 Skeletons.
//<b>战吼：</b>召唤两个1/1的骷髅。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_026t); 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos - 1, own.own); 
            p.callKid(kid, own.zonepos, own.own);
        }
    }
}