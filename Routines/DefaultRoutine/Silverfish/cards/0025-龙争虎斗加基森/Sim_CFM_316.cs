using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_316 : SimTemplate //* 瘟疫鼠群 Rat Pack
//[x]<b>Deathrattle:</b> Summon anumber of 1/1 Rats equal_to this minion's Attack.
//<b>亡语：</b>召唤若干个1/1的老鼠，数量等同于该随从的攻击力。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_316t); 

        public override void onDeathrattle(Playfield p, Minion m)
        {
            int anz = m.Angr;
            if (anz > 0)
            {
                p.callKid(kid, m.zonepos - 1, m.own, false);
                anz--;                
                for (int i = 0; i < anz; i++)
                {
                    p.callKid(kid, m.zonepos - 1, m.own);
                }
            }
        }
    }
}