using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_087: SimTemplate //* 荆棘帮巫婆 Hench-Clan Hag
//<b>Battlecry:</b> Summon two 1/1 Amalgams with all minion types.
//<b>战吼：</b>召唤两个具有全部随从类型的1/1的融合怪。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_026t);
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(kid, own.zonepos - 1, own.own); 
            p.callKid(kid, own.zonepos, own.own);
        }
    }
}