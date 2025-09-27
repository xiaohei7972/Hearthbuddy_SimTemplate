using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：6
	//Blood in the Water
	//血染大海
	//Deal $3 damage to an enemy. Summon a 5/5 Shark with <b>Rush</b>.
	//对一个敌人造成$3点伤害。召唤一条5/5并具有<b>突袭</b>的鲨鱼。
	class Sim_TSC_932 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_237t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}

	}
}
