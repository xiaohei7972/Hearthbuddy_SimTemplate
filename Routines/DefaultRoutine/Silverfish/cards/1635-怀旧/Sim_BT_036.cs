using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_036 : SimTemplate //* 协同打击 Coordinated Strike
	{
		//Summon three 1/1_Illidari with <b>Rush</b>.
		//召唤三个1/1并具有<b>突袭</b>的伊利达雷。
        		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_036t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }		
		
	}
}
