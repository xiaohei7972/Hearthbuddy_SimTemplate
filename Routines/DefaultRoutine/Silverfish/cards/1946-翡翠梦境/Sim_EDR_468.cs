using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：4 攻击力：3 生命值：5
	//Eggbasher
	//捣蛋狂魔
	//<b>Battlecry:</b> Deal 1 damage to a minion and give it+4 Attack.
	//<b>战吼：</b>对一个随从造成1点伤害，并使其获得+4攻击力。
	class Sim_EDR_468 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				// 对目标随从造成1点伤害
				p.minionGetDamageOrHeal(target, 1);

				// 使目标随从获得+4攻击力（永久）
				p.minionGetBuffed(target, 4, 0); // 给予永久的攻击力加成
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]
			{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标也可以使用
            };
		}
	}
}
