using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：2 生命值：2
	//Zola the Gorgon
	//蛇发女妖佐拉
	//<b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
	//<b>战吼：</b>选择一个友方随从。将它的金色复制置入你的手牌。
	class Sim_CORE_LOOT_516 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null) p.drawACard(target.handcard.card.nameEN, own.own, true);
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也可以用
			};
		}
	}
}
