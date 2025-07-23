using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Conjured Arrow
	//咒术之箭
	//Deal $2 damageto a minion.<b>Manathirst (6):</b> Drawthat many cards.
	//对一个随从造成$2点伤害。<b>法力渴求（6）：</b>抽取相同数量的牌。
	class Sim_RLK_804 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			if (target!= null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.minionGetDamageOrHeal(target, dmg);
				if (p.ownMaxMana >= hc.card.Manathirst)
				{
					for (int i = 0; i < dmg; i++)
					{
						p.drawACard(CardDB.cardIDEnum.None, ownplay);
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}

	}
}
