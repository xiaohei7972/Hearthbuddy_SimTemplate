using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：3 攻击力：3 生命值：3
	//Latorvian Armorer
	//拉特维亚护甲师
	//<b>Battlecry:</b> Deal 2 damage to an enemy minion. If it dies, gain 5 Armor.
	//<b>战吼：</b>对一个敌方随从造成2点伤害。如果该随从死亡，获得5点护甲值。
	class Sim_TLC_606 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDamageOrHeal(target, 2);
				if (target.Hp <= 0)
				{
					if (own.own)
					{
						p.ownHero.armor += 5;
					}
					else
					{
						p.enemyHero.armor += 5;
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能用
			};
		}
	}
}
