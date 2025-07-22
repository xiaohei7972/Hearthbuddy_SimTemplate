using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113t7 : SimTemplate //* 强化集群战术 improvedpacktactics
	{
		//<b>奥秘：</b>当一个友方随从受到攻击时，召唤两个该随从的3/3的复制。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_800);//Ironfur Grizzly

		public override void onSecretPlay(Playfield p, bool ownplay, int number)
		{
			int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, place, ownplay);
			p.callKid(kid, place, ownplay);
		}

	}
}
