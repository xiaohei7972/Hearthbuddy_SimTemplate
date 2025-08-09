using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Spirits of the Forest
	//森林之灵
	//<b>Choose One -</b> Summon three 2/3 Wolves with <b>Taunt</b>; or Summon two 4/3 Falcons with <b>Windfury</b>.
	//<b>抉择：</b>召唤三只2/3并具有<b>嘲讽</b>的狼；或者召唤两只4/3并具有<b>风怒</b>的猎鹰。
	class Sim_EDR_233 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_tk11);
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_233t2);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
				p.callKid(kid, pos, ownplay);
			}

			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid1, pos, ownplay);
				p.callKid(kid1, pos, ownplay);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需求一个空位
            };
		}

	}
}
