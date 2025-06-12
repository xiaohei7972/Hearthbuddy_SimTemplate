using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Dissolving Ooze
	//蚀解软泥怪
	//[x]<b>Battlecry:</b> Destroy afriendly minion. Spit outthe Bones of its Attack andHealth into your hand.
	//<b>战吼：</b>消灭一个友方随从，将其骸骨置入你的手牌。骸骨可以使一个随从获得被消灭随从的攻击力和生命值。
	class Sim_TLC_252 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetDestroyed(target);
				p.drawACard(CardDB.cardIDEnum.TLC_829t,true,true);
            }
        }

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE)
			};
		}

		
	}
}
