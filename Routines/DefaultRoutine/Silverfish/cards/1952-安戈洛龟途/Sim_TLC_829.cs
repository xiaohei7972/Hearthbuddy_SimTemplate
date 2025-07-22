using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：3 生命值：3
	//Ravenous Devilsaur
	//饥饿的魔暴龙
	//[x]<b>Battlecry:</b> Destroy a minion.<b>Kindred:</b> Gain its stats.
	//<b>战吼：</b>消灭一个随从。<b>延系：</b>获得被消灭随从的属性值。
	class Sim_TLC_829 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetDestroyed(target);
			}
		}
		
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也能用
			};
		}
	
	}
}
