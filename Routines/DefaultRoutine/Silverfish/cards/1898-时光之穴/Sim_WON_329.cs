using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：5 生命值：4
	//Blackwing Corruptor
	//黑翼腐蚀者
	//<b>Battlecry:</b> If you're holding a Dragon, deal 5 damage.
	//<b>战吼：</b>如果你的手牌中有龙牌，则造成5点伤害。
	class Sim_WON_329 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			bool dragonInHand = false;
			foreach (Handmanager.Handcard hc in p.owncards)
			{
				if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
				{
					dragonInHand = true;
					break;
				}
			}
			if (dragonInHand && target != null)
			{
				p.minionGetDamageOrHeal(target, 5);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND), //手牌里有龙才有目标
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也可以用
			};
		}

	}


}
