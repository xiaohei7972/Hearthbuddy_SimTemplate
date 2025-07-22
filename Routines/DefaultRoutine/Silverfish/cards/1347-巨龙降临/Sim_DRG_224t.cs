using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_224t : SimTemplate //* 风暴龙卵 Storm Egg
	{
		//At the start of your turn, transform into a 4/4 Storm Drake with <b>Rush</b>.
		//在你的回合开始时，变形成为一条4/4并具有<b>突袭</b>的风暴幼龙。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_224t2);//风暴幼龙
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
			if (triggerEffectMinion.own == turnStartOfOwner)
			{
				p.minionTransform(triggerEffectMinion, kid);
			}
		}
	}
}