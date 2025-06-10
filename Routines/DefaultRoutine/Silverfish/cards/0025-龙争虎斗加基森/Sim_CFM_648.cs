using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_648 : SimTemplate //* 犯罪高手 Big-Time Racketeer
//<b>Battlecry:</b> Summon a 6/6_Ogre.
//<b>战吼：</b>召唤一个6/6的食人魔。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_648t); 

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(kid, m.zonepos, m.own);
        }
    }
}