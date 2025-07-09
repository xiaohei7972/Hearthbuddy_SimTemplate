using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：8 攻击力：6 生命值：6
	//Windpeak Wyrm
	//乘风浮龙
	//[x]<b>Battlecry:</b> Deal 5 damageand gain 5 Armor.<b>Kindred:</b> Costs (3) less.
	//<b>战吼：</b>造成5点伤害，获得5点护甲值。<b>延系：</b>法力值消耗减少（3）点。
	class Sim_TLC_600 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDamageOrHeal(target, 5);
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

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}

	}
}
