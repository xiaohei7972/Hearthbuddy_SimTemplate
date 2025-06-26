using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：5 生命值：4
	//Spinetail Drake
	//棘尾幼龙
	//<b>Battlecry:</b> If you're holdinga Dragon, deal 5 damageto an enemy minion.
	//<b>战吼：</b>如果你的手牌中有龙牌，则对一个敌方随从造成5点伤害。
	class Sim_WW_820 : SimTemplate
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
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也可以用
			};
		}

	}

}
