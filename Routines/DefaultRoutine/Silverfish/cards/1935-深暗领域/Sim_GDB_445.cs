using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：6
	//Meteor Storm
	//陨石风暴
	//Deal $5 damageto all minions.Shuffle 5 Asteroidsinto your deck.
	//对所有随从造成$5点伤害。将5张小行星洗入你的牌库。
	class Sim_GDB_445 : SimTemplate
	{
		CardDB.Card eruptionCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_430); // 爆发卡的ID
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.allMinionsGetDamage(dmg);

			for (int i = 0; i < 5; i++)
			{
				p.AddToDeck(eruptionCard);
			}
		}
		
	}
}
