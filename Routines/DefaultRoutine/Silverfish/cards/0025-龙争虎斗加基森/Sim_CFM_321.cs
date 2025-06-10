using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_321 : SimTemplate //* 污手街情报员 Grimestreet Informant
//[x]<b>Battlecry:</b> <b>Discover</b> aHunter, Paladin, or Warriorcard.
//<b>战吼：</b><b>发现</b>一张猎人、圣骑士或战士卡牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.shieldbearer, m.own, true);
        }
    }
}