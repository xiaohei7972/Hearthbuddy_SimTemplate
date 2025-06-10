using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_940 : SimTemplate //* 唤醒造物者 Awaken the Makers
//<b>Quest:</b> Summon7 <b>Deathrattle</b> minions.<b>Reward:</b> Amara, Warden of Hope.
//<b>任务：</b>召唤7个具有<b>亡语</b>的随从。<b>奖励：</b>希望守护者阿玛拉。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}