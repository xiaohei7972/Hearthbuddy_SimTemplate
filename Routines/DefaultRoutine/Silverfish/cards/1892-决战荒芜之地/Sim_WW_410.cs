using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：7
	//Triple Sevens
	//三条七
	//Deal $7 damage to a minion. Draw 7 cards.
	//对一个随从造成$7点伤害。抽7张牌。
	class Sim_WW_410 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(7) : p.getEnemySpellDamageDamage(7);
				p.minionGetDamageOrHeal(target, damage);
				for (int i = 0; i < 7; i++)
				{
					p.drawACard(CardDB.cardIDEnum.None, ownplay);
				}
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //只能是随从
			};
		}
		
	}
}
