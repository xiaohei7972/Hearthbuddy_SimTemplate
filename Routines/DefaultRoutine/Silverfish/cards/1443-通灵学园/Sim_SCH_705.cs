using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_705 : SimTemplate //* 邪犬训练师 Vilefiend Trainer
	{
		//<b>Outcast:</b> Summon two 1/1_Demons.
		//<b>流放：</b>召唤两个1/1的恶魔。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_705t);
		public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
		{
			if (outcast)
			{
				p.callKid(kid, own.zonepos - 1, own.own);
				p.callKid(kid, own.zonepos, own.own);
				p.evaluatePenality -= 1;
			}
			else p.evaluatePenality += 3;			
		}
	}
}
