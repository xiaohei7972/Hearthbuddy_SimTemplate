using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Chill Vibes
	//清冷音韵
	//Restore #8 Health.<b>Finale:</b> Summon a 3/3Elemental with <b>Taunt</b>.
	//恢复#8点生命值。<b>压轴：</b>召唤一个3/3并具有<b>嘲讽</b>的元素。
	class Sim_ETC_369 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(-8) : p.getEnemySpellHeal(-8);
				p.minionGetDamageOrHeal(target, heal);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
			};
		}
		
	}
}
