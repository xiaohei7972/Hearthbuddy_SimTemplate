using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Demonic Deal
	//恶魔交易
	//[x]<b>Lifesteal</b>. Deal $4 damageto a minion. Put a randomDemon that costs (5) ormore on top of your deck.
	//<b>吸血</b>对一个随从造成$4点伤害。将一张法力值消耗大于或等于（5）点的随机恶魔牌置于你的牌库顶。
	class Sim_WORK_014 : SimTemplate
	{
		//默认添加恐怖末日守卫
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_020);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
				// 对一个随从造成4点伤害
				p.minionGetDamageOrHeal(target, damage);
				p.AddToDeck(card);
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
		}

	}
}
