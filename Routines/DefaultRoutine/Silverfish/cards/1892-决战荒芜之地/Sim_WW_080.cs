using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Amphibious Elixir
	//两栖药剂
	//Restore #5 Health. <b>Discover</b> a spell.
	//恢复#5点生命值。<b>发现</b>一张法术牌。
	class Sim_WW_080 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int heal = ownplay ? p.getSpellHeal(-5) : p.getEnemySpellHeal(-5);
				p.minionGetDamageOrHeal(target, heal);
				p.drawACard(CardDB.cardIDEnum.None, ownplay,true);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2. REQ_TARGET_TO_PLAY),
			};
		}
		
	}
}
