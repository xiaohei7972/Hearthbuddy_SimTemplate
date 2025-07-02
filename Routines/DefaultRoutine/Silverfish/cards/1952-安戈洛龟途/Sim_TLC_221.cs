using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：6
	//Sizzling Swarm
	//炽火缠身
	//Deal $3 damage.Summon that many 2/1 Sizzling Cinders.
	//造成$3点伤害，召唤相同数量的2/1的炽烈烬火。
	class Sim_TLC_221 : SimTemplate
	{


		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_249);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, damage);
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				for (int i = 0; i < damage; i++)
				{
					p.callKid(kid, pos, ownplay);
				}
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 最少需要一个位置
			};
		}

	}
}
