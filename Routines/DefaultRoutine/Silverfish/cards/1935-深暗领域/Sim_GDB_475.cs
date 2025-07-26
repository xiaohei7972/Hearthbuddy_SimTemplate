using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Orbital Moon
	//近轨血月
	//Give a minion <b>Taunt</b> and <b>Lifesteal</b>. If you played an adjacent card this turn, also give it <b>Reborn</b>.
	//使一个随从获得<b>嘲讽</b>和<b>吸血</b>。如果你在本回合中使用过相邻的牌，还会使其获得<b>复生</b>。
	class Sim_GDB_475 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				target.taunt = true;
				target.lifesteal = true;
				//TODO:复生以后再说

			}

		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET) // 目标只能是随从

			};

		}
		
	}
}
