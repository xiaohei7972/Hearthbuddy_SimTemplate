using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Shadowflame Suffusion
	//影焰晕染
	//[x]Deal $2 damage.<b>Discover</b> a Warriorminion with a <b>Dark Gift</b>.
	//造成$2点伤害。<b>发现</b>一张具有<b>黑暗之赐</b>的战士随从牌。
	class Sim_FIR_939 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				int damage = ownplay ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
			}
        }
		
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
			};
		}
	}
}
