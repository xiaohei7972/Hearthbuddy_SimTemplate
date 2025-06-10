using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_028t5 : SimTemplate //* 船长洛卡拉 Cap'n Rokara
	{
        //<b>Battlecry:</b> Summon The Juggernaut!
        //<b>战吼：</b>召唤毁灭战舰！
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_028t6), own.zonepos, own.own);
        }

    }
}
