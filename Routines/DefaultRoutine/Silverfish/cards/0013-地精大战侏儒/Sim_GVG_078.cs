using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_078 : SimTemplate //* 机械雪人 Mechanical Yeti
//<b>Deathrattle:</b> Give each player a <b>Spare Part.</b>
//<b>亡语：</b>使每个玩家获得一张<b>零件</b>牌。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.armorplating, false, true);
            p.drawACard(CardDB.cardIDEnum.None, true, true);
        }
    }
}