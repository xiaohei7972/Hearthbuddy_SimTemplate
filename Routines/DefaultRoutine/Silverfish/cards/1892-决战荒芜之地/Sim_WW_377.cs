using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Heat Wave
	//热浪来袭
	//[x]Deal $2 damageto an enemy minion andits neighbors. <b>Quickdraw:</b>To all enemies instead.
	//对一个敌方随从及其相邻随从造成$2点伤害。<b>快枪：</b>改为对所有敌人。
	class Sim_WW_377 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2); // 如果目标不是自己，则使用伤害
			p.minionGetDamageOrHeal(target, dmg); // 对目标造成伤害
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
			};
		}
	}
}
