using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：7
	//Frostwyrm's Fury
	//冰霜巨龙之怒
	//Deal $5 damage. <b>Freeze</b> all enemy minions.Summon a 5/5 Frostwyrm.
	//造成$5点伤害。<b>冻结</b>所有敌方随从。召唤一条5/5的冰霜巨龙。
	class Sim_RLK_Prologue_RLK_063 : SimTemplate
	{
		//获取冰霜巨龙信息
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_Prologue_RLK_063t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				//获取法术伤害
				int damage = ownplay ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
				//获取位置
				int pos = ownplay ? p.enemyMinions.Count : p.ownMinions.Count;

				//对目标造成伤害
				p.minionGetDamageOrHeal(target, damage);

				//获取敌方随从列表
				List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
				foreach (Minion minion in minions)
				{
					//所有敌方随从
					p.minionGetFrozen(minion);
				}

				//召唤冰霜巨龙
				p.callKid(kid, pos, ownplay);

			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //目标只能是敌方
			};
		}


	}
}
