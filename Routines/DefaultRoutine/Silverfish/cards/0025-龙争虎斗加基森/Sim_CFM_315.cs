using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_315 : SimTemplate //* 雄斑虎 Alleycat
//<b>Battlecry:</b> Summon a 1/1_Cat.
//<b>战吼：</b>召唤一个1/1的雌斑虎。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_315t); 

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(kid, m.zonepos, m.own);
        }
    }
}