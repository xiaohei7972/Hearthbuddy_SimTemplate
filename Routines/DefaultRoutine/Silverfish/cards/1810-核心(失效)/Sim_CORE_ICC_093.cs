using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：3
	//Tuskarr Fisherman
	//海象人渔夫
	//<b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
	//<b>战吼：</b>使一个友方随从获得<b>法术伤害+1</b>。
	class Sim_CORE_ICC_093 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				target.spellpower++;
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也能用
            };
		}

	}
}
