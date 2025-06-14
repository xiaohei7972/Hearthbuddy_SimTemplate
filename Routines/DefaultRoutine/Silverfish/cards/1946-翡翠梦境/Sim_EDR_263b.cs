using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//Greatwolf's Guidance
	//巨狼的指引
	//Summon two 3/2 Wolves with <b>Rush</b>.
	//召唤两只3/2并具有<b>突袭</b>的狼。
	class Sim_EDR_263b : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_850pe);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
		}


	}
}
