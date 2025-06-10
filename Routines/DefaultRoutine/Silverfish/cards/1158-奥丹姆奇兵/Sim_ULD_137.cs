using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ULD_137: SimTemplate //* 园艺侏儒 Garden Gnome
//[x]<b>Battlecry:</b> If you're holdinga spell that costs (5) or more,summon two 2/2 Treants.
//<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，便召唤两个2/2的树人。 
    {
        
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_137t); 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.cost >= 5 && hc.card.type == CardDB.cardtype.SPELL)
                    {
                        p.callKid(kid, own.zonepos, own.own, false);
                        p.callKid(kid, own.zonepos - 1, own.own);
                        break;
                    }
                }
            }
        }
    }
}