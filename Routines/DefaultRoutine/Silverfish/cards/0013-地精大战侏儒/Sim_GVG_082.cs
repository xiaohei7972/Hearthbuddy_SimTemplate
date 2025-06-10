using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_082 : SimTemplate //* 发条侏儒 Clockwork Gnome
//<b>Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
//<b>亡语：</b>将一张<b>零件</b>牌置入你的手牌。 
    {

        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}