using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_016 : SimTemplate //* 空中私掠者 Skyvateer
	{
		//<b>Stealth</b><b>Deathrattle:</b> Draw a card.
		//<b>潜行</b><b>亡语：</b>抽一张牌。
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.unknown, m.own);
        }
		
	}
}
