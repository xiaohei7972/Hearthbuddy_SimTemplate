using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Canary
	//金丝雀
	//<b>Battlecry:</b> Return anenemy minion to its owner's hand.
	//<b>战吼：</b>将一个敌方随从移回其拥有者的手牌。
	class Sim_WW_001t7 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			// 检查是否有敌方随从可以作为目标
			if (target != null && !target.own)
			{
				// 将敌方随从移回其拥有者的手牌
				p.minionReturnToHand(target, target.own, 0);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			// 扰魔是不吃法术和英雄技能的指定 但是随从技能没办法 参考萨隆偷带扰魔的奇利亚斯
			return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}
	}
}
