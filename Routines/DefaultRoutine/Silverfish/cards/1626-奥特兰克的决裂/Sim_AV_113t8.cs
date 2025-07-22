using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_113t8 : SimTemplate //* 强化打开兽笼 improvedopenthecages
	{
		//<b>奥秘：</b>当你的回合开始时，如果你控制着两个随从，召唤两个动物伙伴。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NEW1_032);//misha
		public override void onSecretPlay(Playfield p, bool ownplay, int number)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
		}

	}
}
