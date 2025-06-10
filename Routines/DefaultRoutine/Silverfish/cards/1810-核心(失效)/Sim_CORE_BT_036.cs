using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_BT_036 : SimTemplate //* 协同打击 Coordinated Strike
	{
		//Summon three 1/1_Illidari with <b>Rush</b>.
		//召唤三个1/1并具有<b>突袭</b>的伊利达雷。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_036t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = p.ownMinions.Count;
			p.callKid(kid, pos + 1, ownplay);
			p.callKid(kid, pos + 2, ownplay);
			p.callKid(kid, pos + 3, ownplay);
		}
	}
}
