using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_116 : SimTemplate //* 丛林巨兽 Jungle Giants
//[x]<b>Quest:</b> Summon5 minions with5 or more Attack.<b>Reward:</b> Barnabus.
//<b>任务：</b>召唤5个攻击力大于或等于5的随从。<b>奖励：</b>班纳布斯。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}