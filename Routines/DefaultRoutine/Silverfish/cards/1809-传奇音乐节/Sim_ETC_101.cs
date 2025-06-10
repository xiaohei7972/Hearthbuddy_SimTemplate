using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：4 生命值：2
	//Cowbell Soloist
	//牛铃独演者
	//[x]<b>Battlecry:</b> If you controlno other minions, deal2 damage.
	//<b>战吼：</b>如果你没有控制其他随从，造成2点伤害。
	class Sim_ETC_101 : SimTemplate
	{
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.ownMinions.Count == 1) {
	            int dmg = 2;
				if (target != null) p.minionGetDamageOrHeal(target, dmg);
			}
		}
		
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
		
	}
}
