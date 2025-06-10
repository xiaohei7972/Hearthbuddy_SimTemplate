using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_023 : SimTemplate //* 砰砰战队 Boom Squad
	{
		//<b>Discover</b> a <b>Lackey</b>, Mech, or Dragon.
		//<b>发现</b>一张<b>跟班</b>牌，机械牌或龙牌。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
        }
		
	}
}
