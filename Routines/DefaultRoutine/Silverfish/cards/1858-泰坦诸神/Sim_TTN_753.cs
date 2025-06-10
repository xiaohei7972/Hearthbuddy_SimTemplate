using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：3
	//Bellowing Flames
	//鼓动火焰
	//Deal $5 damage to a minion. <b>Forge:</b> Then deal $5 damage split among all enemy minions.
	//对一个随从造成$5点伤害。<b>锻造：</b>然后造成$5点伤害，随机分配到所有敌方随从身上。
	class Sim_TTN_753 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5); 
			p.minionGetDamageOrHeal(target, dmg); 
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}
	}
}
