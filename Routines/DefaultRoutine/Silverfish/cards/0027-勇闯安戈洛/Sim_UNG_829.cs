using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_829 : SimTemplate //* 拉卡利献祭 Lakkari Sacrifice
//[x]<b>Quest:</b> Discard 6 cards.<b>Reward:</b> Nether Portal.
//<b>任务：</b>弃掉六张牌。<b>奖励：</b>虚空传送门。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}