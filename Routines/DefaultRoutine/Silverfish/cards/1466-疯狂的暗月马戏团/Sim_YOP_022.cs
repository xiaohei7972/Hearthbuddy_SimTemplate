using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：4 生命值：4
	//Mistrunner
	//迷雾行者
	//<b>Battlecry:</b> Give a friendly minion +3/+3.<b>Overload:</b> (1)
	//<b>战吼：</b>使一个友方随从获得+3/+3。<b>过载：</b>（1）
	class Sim_YOP_022 : SimTemplate
	{
        public override void onCardPlay(Playfield p, Minion own, bool ownplay, Minion target, int choice, bool outcast)
        {
			if (own.own) p.lockedMana++;
        }
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 3, 3);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
		}
		
	}
}
